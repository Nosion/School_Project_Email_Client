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

        http://blog.tigrangasparian.com/2012/02/09/getting-started-with-sqlite-in-c-part-one/
            //Creating DB
            SQLiteConnection.CreateFile("db.sqlite");

            //Connection object
            SQLiteConnection dbConnection;
            
            dbConnection





            list = new List<OpenPop.Mime.Message>();

            worker.WorkerReportsProgress = true;
            
            worker.DoWork += new DoWorkEventHandler(fetchAllMessages);
            worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(OnRunWorkerCompleted);
        }

        private void ReciveMailbtn_Click(object sender, EventArgs e)
        {
            //  FetchAllMessages(); BGWorker
            if (!worker.IsBusy)
            {
                pbxWorking.Visible = true;
                worker.RunWorkerAsync();
            }
        }

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
                List<OpenPop.Mime.Message> allMessages = new List<OpenPop.Mime.Message>(messageCount);

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

            foreach (OpenPop.Mime.Message message in list)
            {
                Subjectlsbx.Items.Add(message.Headers.Subject.ToString());//OpenPop.Mime.Message mail
            }
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
    }
}
