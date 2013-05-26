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
using OpenPop.Pop3;

namespace EmailClient
{
    public partial class NewMail : Form
    {
        public NewMail()
        {
            InitializeComponent();
        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("dumdum13377@gmail.com");
                mail.To.Add(SendTotbx.Text);
                mail.Subject = Subjecttbx.Text;
                mail.Body = Messagetbx.Text;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("dumdum13377@gmail.com", "Grus61mHg");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

  
    }
}
