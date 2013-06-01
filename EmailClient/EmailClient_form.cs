using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SQLite;
using OpenPop.Pop3;
using System.Diagnostics;


namespace EmailClient
{
	public partial class EmailClient_form : Form
	{
		List<OpenPop.Mime.Message> list;
		List<Msg> dbmsg = new List<Msg>();
		SqlHandler sqlHandler = new SqlHandler();
		SQLiteConnection sqliteCon;


	  //  public SQLiteConnection sqliteCon;

		public EmailClient_form()
		{
			InitializeComponent();

#region SQLConnection & DB creation           
  
			sqliteCon = sqlHandler.sqliteCon;
			sqlHandler.CreateDB();



            subjectlsbx.Items.Clear();
            dbmsg.Clear();
            dbmsg = sqlHandler.listDbMsg();

            foreach (Msg msg in dbmsg)
            {
                subjectlsbx.Items.Add(msg.MsgSubject);
            }

#endregion

			list = new List<OpenPop.Mime.Message>();

			worker.WorkerReportsProgress = true;
			
			worker.DoWork += new DoWorkEventHandler(fetchAllMessages);
			worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
			worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(OnRunWorkerCompleted);
		} // EmailClient_form end
	   
		#region Menue Items
		private void sendToolStripMenuItem1_Click(object sender, EventArgs e)
		{
		  
		}

		private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Close();
		}

 

		private void newMailToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NewMail _NewMail = new NewMail();
			_NewMail.ShowDialog();
		}
		#endregion


	


		private void ReciveMailbtn_Click_1(object sender, EventArgs e)
		{
			//  FetchAllMessages(); BGWorker
			if (!worker.IsBusy)
			{
				pbxWorking.Visible = true;
				worker.RunWorkerAsync();
			}
		}


		//Getting the different messageparts .. more on this http://stackoverflow.com/questions/10601913/openpop-net-get-actual-message-text
		private void subjectlsbx_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			int selectedItem = subjectlsbx.SelectedIndex;
			try
			{
				msgBodytbx.Text = dbmsg[selectedItem].MsgBody; // Shows the message body when choosing a subject from subjectlsbx
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}


		private static void fetchAllMessages(object sender, DoWorkEventArgs e)
		{
			int percentComplete;
			// The client disconnects from the server when being disposed
			using (Pop3Client client = new Pop3Client())
			{
				// Connect to the server  pop.myopera.com
				client.Connect("pop.gmail.com", 995, true);

				// Authenticate ourselves towards the server /HejHej
				client.Authenticate("dumdum13377", "Grus61mHg");
								
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

			sqlHandler.InsertMsgInto(list);


			subjectlsbx.Items.Clear();
			dbmsg.Clear();
			dbmsg = sqlHandler.listDbMsg();
			
			foreach (Msg msg in dbmsg)
			{
				subjectlsbx.Items.Add(msg.MsgSubject);
			}
			
			#endregion
		}

		private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			progressBar1.Value = e.ProgressPercentage;
		}
		
	}
}
