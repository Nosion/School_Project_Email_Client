using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenPop.Pop3;

namespace EmailClient
{
    public partial class Settings_form : Form
    {
        public Settings_form()
        {
            InitializeComponent();


            if (Properties.Settings.Default.UserName != null)
            {

                lbCurrentUsr.Text = Properties.Settings.Default.UserName;
            }
            else
            {
                lbCurrentUsr.Text = "No Current user is saved.";
            }
            lbCurrentUsr.Update();
        }


        public void button1_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.UserName = textBox1.Text.ToString();
            Properties.Settings.Default.Password = textBox2.Text.ToString();

            lbAuth.Text = "";
            pbxAuthOk.Visible = false;
            pbxAuthFail.Visible = false;
                    

            try
            {
                using (Pop3Client client = new Pop3Client())
                {
                    

                    // Connect to the server  pop.myopera.com
                    client.Connect("pop.myopera.com", 995, true);

                    // Authenticate ourselves towards the server /HejHej
                    client.Authenticate(Properties.Settings.Default.UserName, Properties.Settings.Default.Password);

                    if (client.Connected == true)
                    {
                        pbxAuthOk.Visible = true;
                        lbAuth.Text = "Authentication OK!";
                        Properties.Settings.Default.Save();
                    }
                    
                    client.Disconnect();
                }
            }
            catch (Exception)
            {
                pbxAuthFail.Visible = true;
                lbAuth.Text = "Something's wrong! \nMaybe bad username or password..";
                Properties.Settings.Default.UserName = null;
                Properties.Settings.Default.Save();

               if (Properties.Settings.Default.UserName != null)
                {

                    lbCurrentUsr.Text = Properties.Settings.Default.UserName;
                }
                else
                {
                    lbCurrentUsr.Text = "No Current user is saved.";
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
