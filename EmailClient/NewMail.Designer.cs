namespace EmailClient
{
    partial class NewMail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sendbtn = new System.Windows.Forms.Button();
            this.SendTolb = new System.Windows.Forms.Label();
            this.SendTotbx = new System.Windows.Forms.TextBox();
            this.Messagelb = new System.Windows.Forms.Label();
            this.Subjectlb = new System.Windows.Forms.Label();
            this.Messagetbx = new System.Windows.Forms.RichTextBox();
            this.Subjecttbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Sendbtn
            // 
            this.Sendbtn.Location = new System.Drawing.Point(489, 412);
            this.Sendbtn.Name = "Sendbtn";
            this.Sendbtn.Size = new System.Drawing.Size(75, 23);
            this.Sendbtn.TabIndex = 15;
            this.Sendbtn.Text = "Send";
            this.Sendbtn.UseVisualStyleBackColor = true;
            this.Sendbtn.Click += new System.EventHandler(this.Sendbtn_Click);
            // 
            // SendTolb
            // 
            this.SendTolb.AutoSize = true;
            this.SendTolb.Location = new System.Drawing.Point(153, 114);
            this.SendTolb.Name = "SendTolb";
            this.SendTolb.Size = new System.Drawing.Size(20, 13);
            this.SendTolb.TabIndex = 14;
            this.SendTolb.Text = "To";
            // 
            // SendTotbx
            // 
            this.SendTotbx.Location = new System.Drawing.Point(186, 111);
            this.SendTotbx.Name = "SendTotbx";
            this.SendTotbx.Size = new System.Drawing.Size(378, 20);
            this.SendTotbx.TabIndex = 13;
            this.SendTotbx.Text = "dumdum13377@gmail.com";
            // 
            // Messagelb
            // 
            this.Messagelb.AutoSize = true;
            this.Messagelb.Location = new System.Drawing.Point(130, 179);
            this.Messagelb.Name = "Messagelb";
            this.Messagelb.Size = new System.Drawing.Size(50, 13);
            this.Messagelb.TabIndex = 12;
            this.Messagelb.Text = "Message";
            // 
            // Subjectlb
            // 
            this.Subjectlb.AutoSize = true;
            this.Subjectlb.Location = new System.Drawing.Point(137, 140);
            this.Subjectlb.Name = "Subjectlb";
            this.Subjectlb.Size = new System.Drawing.Size(43, 13);
            this.Subjectlb.TabIndex = 11;
            this.Subjectlb.Text = "Subject";
            // 
            // Messagetbx
            // 
            this.Messagetbx.Location = new System.Drawing.Point(186, 176);
            this.Messagetbx.Name = "Messagetbx";
            this.Messagetbx.Size = new System.Drawing.Size(378, 220);
            this.Messagetbx.TabIndex = 10;
            this.Messagetbx.Text = "Write something";
            // 
            // Subjecttbx
            // 
            this.Subjecttbx.Location = new System.Drawing.Point(186, 137);
            this.Subjecttbx.Name = "Subjecttbx";
            this.Subjecttbx.Size = new System.Drawing.Size(378, 20);
            this.Subjecttbx.TabIndex = 9;
            this.Subjecttbx.Text = "test";
            // 
            // NewMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 547);
            this.Controls.Add(this.Sendbtn);
            this.Controls.Add(this.SendTolb);
            this.Controls.Add(this.SendTotbx);
            this.Controls.Add(this.Messagelb);
            this.Controls.Add(this.Subjectlb);
            this.Controls.Add(this.Messagetbx);
            this.Controls.Add(this.Subjecttbx);
            this.Name = "NewMail";
            this.Text = "NewMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sendbtn;
        private System.Windows.Forms.Label SendTolb;
        private System.Windows.Forms.TextBox SendTotbx;
        private System.Windows.Forms.Label Messagelb;
        private System.Windows.Forms.Label Subjectlb;
        private System.Windows.Forms.RichTextBox Messagetbx;
        private System.Windows.Forms.TextBox Subjecttbx;

    }
}