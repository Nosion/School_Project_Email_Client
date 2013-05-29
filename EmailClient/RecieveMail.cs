using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenPop.Common.Logging;
using OpenPop.Mime;
using OpenPop.Mime.Decode;
using OpenPop.Mime.Header;
using OpenPop.Pop3;
using System.IO;
using System.Data.SQLite;

namespace EmailClient
{
    public partial class RecieveMail : Form
    {
        List<OpenPop.Mime.Message> list;       
        
        public RecieveMail()
        {
            InitializeComponent();

#region SQLConnection & DB creation             
                try{
                    string dbConnString = @"Data Source=db.sqlite; Version=3;"; // Creating the connection string with filepath to the DB
                    SQLiteConnection sqliteCon = new SQLiteConnection(dbConnString); // Creating new connection string instance.
 
                    sqliteCon.Open(); // Open database

                    
                        // Defining the SQL Create table string 
                        string crtMessagetblSQL = "CREATE TABLE IF NOT EXISTS [Messages] (" + 
                            "[msgID] TEXT NOT NULL PRIMARY KEY," + 
                            "[msgSender] TEXT NULL," +
                            "[msgSubject] TEXT NULL," + 
                            "[msgBody] TEXT NULL" +
                            ")";

                        using (SQLiteTransaction sqlTrans = sqliteCon.BeginTransaction())
                        {
                            SQLiteCommand crtComm = new SQLiteCommand(crtMessagetblSQL, sqliteCon);

                            crtComm.ExecuteNonQuery();

                         //   crtComm.Dispose();

                            sqlTrans.Commit(); // Commit changes into the DB
                         } // End using

                     sqliteCon.Close(); // Closes DB connection

                    } // End try

                    catch (SQLiteException e)
                    {
                        MessageBox.Show(e.ToString());
                    } // End catch
#endregion

            list = new List<OpenPop.Mime.Message>();

            worker.WorkerReportsProgress = true;
            
            worker.DoWork += new DoWorkEventHandler(fetchAllMessages);
            worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(OnRunWorkerCompleted);
        } // RecieveMail end

        private void ReciveMailbtn_Click(object sender, EventArgs e)
        {
            //  FetchAllMessages(); BGWorker
            if (!worker.IsBusy)
            {
                pbxWorking.Visible = true;
                worker.RunWorkerAsync();
            }
        }

        //Getting the different messageparts .. more on this http://stackoverflow.com/questions/10601913/openpop-net-get-actual-message-text
        private void Subjectlsbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedItem = Subjectlsbx.SelectedIndex;
            if (!list[selectedItem].MessagePart.IsMultiPart)
            {
                msgBodytbx.Text = list[selectedItem].MessagePart.GetBodyAsText();
            }
            else
            {
                OpenPop.Mime.MessagePart plainText = list[selectedItem].FindFirstPlainTextVersion();
                msgBodytbx.Text = plainText.GetBodyAsText();              
            }
        }

        private static void fetchAllMessages(object sender, DoWorkEventArgs e)
        {
            int percentComplete;
            // The client disconnects from the server when being disposed
            using (Pop3Client client = new Pop3Client())
            {
                // Connect to the server
                client.Connect("pop.gmail.com", 995, true);

                // Authenticate ourselves towards the server
                client.Authenticate("dumdum13377@gmail.com", "Grus61mHg");

                
                // Get the number of messages in the inbox
                int messageCount = client.GetMessageCount();

                // We want to download all messages
                List<OpenPop.Mime.Message> allMessages = new List<OpenPop.Mime.Message>();

                // Messages are numbered in the interval: [1, messageCount]
                // Ergo: message numbers are 1-based.
                // Most servers give the latest message the highest number

                for (int i = messageCount; i > 0; i--)
                {
                    allMessages.Add(client.GetMessage(i));
                    percentComplete = Convert.ToInt16((Convert.ToDouble(allMessages.Count) / Convert.ToDouble(messageCount)) * 100);
                    (sender as BackgroundWorker).ReportProgress(percentComplete);
                }
                // Now return the fetched messages to e
                e.Result = allMessages;
            }
        }

        private void OnRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbxWorking.Visible = false;
            list = (List<OpenPop.Mime.Message>)e.Result;

            msgcounglb.Text = Convert.ToString(list.Count);

#region Insert messages into db
            string dbConnString = @"Data Source=db.sqlite; Version=3;"; // Creating the connection string with filepath to the DB
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnString); // Creating new connection string instance.
            sqliteCon.Open(); // Open database

            SQLiteTransaction sqlTrans;


            SQLiteCommand comInsert = new SQLiteCommand("INSERT OR IGNORE INTO messages (msgID, msgSender, msgSubject, msgBody) VALUES (@msgID, @msgSender, @msgSubject, @msgBody)", sqliteCon);

            foreach (OpenPop.Mime.Message message in list)
            {
                if (message.Headers.MessageId != null)
                {
                    comInsert.Parameters.AddWithValue("@msgID", message.Headers.MessageId);
                    comInsert.Parameters.AddWithValue("@msgSender", message.Headers.Sender);
                    comInsert.Parameters.AddWithValue("@msgSubject", message.Headers.Subject);
                    if (!message.MessagePart.IsMultiPart)
                    {
                        comInsert.Parameters.AddWithValue("@msgBody", message.MessagePart.GetBodyAsText());
                    }
                    else
                    {
                        OpenPop.Mime.MessagePart plaintext = message.FindFirstPlainTextVersion();
                        comInsert.Parameters.AddWithValue("@msgBody", plaintext.GetBodyAsText());
                    }
                    //sqlTrans = sqliteCon.BeginTransaction();
                    //int result = comInsert.ExecuteNonQuery();
                    //sqlTrans.Commit();



                    sqlTrans = sqliteCon.BeginTransaction();
                    int result = comInsert.ExecuteNonQuery();
                    
                    sqlTrans.Commit(); // Commit changes into the DB





                    Subjectlsbx.Items.Add(message.Headers.Subject.ToString());
                }

               // comInsert.Dispose();
                sqliteCon.Close();
#endregion

           
                //Subjectlsbx.Items.Add(message.Headers.Subject.ToString());//OpenPop.Mime.Message mail
            }
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
    }
}
