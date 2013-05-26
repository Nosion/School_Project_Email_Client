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


namespace EmailClient
{
    public partial class EmailClient_form : Form
    {
        public EmailClient_form()
        {
            InitializeComponent();
        }

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

        private void recievedMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecieveMail _RecieveMail = new RecieveMail();
            _RecieveMail.ShowDialog();
        }
    }
}
