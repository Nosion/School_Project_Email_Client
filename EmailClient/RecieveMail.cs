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

namespace EmailClient
{
    public partial class RecieveMail : Form
    {
        List<OpenPop.Mime.Message> list;
        
        public RecieveMail()
        {
            InitializeComponent();
            list = new List<OpenPop.Mime.Message>();
            
        }

        private void ReciveMailbtn_Click(object sender, EventArgs e)
        {   
            
            //  FetchAllMessages(); BGWorker
            if (backgroundWorker1.IsBusy){
               //Do nothing
            }
            else{
                backgroundWorker1.RunWorkerAsync();
            }


            //Picture indicates when reciving POP mails.
            if (backgroundWorker1.IsBusy == false)
            {
                pbxWorking.Visible = false;
            }
            //else
            //    pbxWorking.Visible = false;



            
            msgcounglb.Text = Convert.ToString(list.Count);

            foreach (OpenPop.Mime.Message message in list)
            {
                Subjectlsbx.Items.Add(message.Headers.Subject.ToString());//OpenPop.Mime.Message mail
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
               
//                msgBodytbx.Text = "Multi-part message, you need to write somew code to handle this";
            }
        }


        private static List<OpenPop.Mime.Message> fetchAllMessages()
        {
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
                }

                // Now return the fetched messages
                 return allMessages;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            list = fetchAllMessages();  
        }
        
    }
}
