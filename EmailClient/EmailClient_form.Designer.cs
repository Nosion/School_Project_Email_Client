namespace EmailClient
{
    partial class EmailClient_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailClient_form));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pbxWorking = new System.Windows.Forms.PictureBox();
            this.msgBodytbx = new System.Windows.Forms.RichTextBox();
            this.subjectlsbx = new System.Windows.Forms.ListBox();
            this.msgcounglb = new System.Windows.Forms.Label();
            this.ReciveMailbtn = new System.Windows.Forms.Button();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.NewMailbtn = new System.Windows.Forms.Button();
            this.Settingsbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWorking)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 527);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(827, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 13;
            // 
            // pbxWorking
            // 
            this.pbxWorking.Image = ((System.Drawing.Image)(resources.GetObject("pbxWorking.Image")));
            this.pbxWorking.Location = new System.Drawing.Point(12, 12);
            this.pbxWorking.Name = "pbxWorking";
            this.pbxWorking.Size = new System.Drawing.Size(21, 21);
            this.pbxWorking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxWorking.TabIndex = 12;
            this.pbxWorking.TabStop = false;
            this.pbxWorking.Visible = false;
            // 
            // msgBodytbx
            // 
            this.msgBodytbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msgBodytbx.Location = new System.Drawing.Point(322, 40);
            this.msgBodytbx.Name = "msgBodytbx";
            this.msgBodytbx.Size = new System.Drawing.Size(517, 435);
            this.msgBodytbx.TabIndex = 11;
            this.msgBodytbx.Text = "";
            // 
            // subjectlsbx
            // 
            this.subjectlsbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.subjectlsbx.FormattingEnabled = true;
            this.subjectlsbx.Location = new System.Drawing.Point(166, 40);
            this.subjectlsbx.Name = "subjectlsbx";
            this.subjectlsbx.Size = new System.Drawing.Size(150, 433);
            this.subjectlsbx.TabIndex = 10;
            this.subjectlsbx.SelectedIndexChanged += new System.EventHandler(this.subjectlsbx_SelectedIndexChanged_1);
            // 
            // msgcounglb
            // 
            this.msgcounglb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.msgcounglb.AutoSize = true;
            this.msgcounglb.Location = new System.Drawing.Point(12, 502);
            this.msgcounglb.Name = "msgcounglb";
            this.msgcounglb.Size = new System.Drawing.Size(27, 13);
            this.msgcounglb.TabIndex = 9;
            this.msgcounglb.Text = "N/A";
            // 
            // ReciveMailbtn
            // 
            this.ReciveMailbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReciveMailbtn.BackgroundImage")));
            this.ReciveMailbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReciveMailbtn.Location = new System.Drawing.Point(79, 1);
            this.ReciveMailbtn.Name = "ReciveMailbtn";
            this.ReciveMailbtn.Size = new System.Drawing.Size(32, 32);
            this.ReciveMailbtn.TabIndex = 8;
            this.ReciveMailbtn.UseVisualStyleBackColor = true;
            this.ReciveMailbtn.Click += new System.EventHandler(this.ReciveMailbtn_Click_1);
            // 
            // NewMailbtn
            // 
            this.NewMailbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NewMailbtn.BackgroundImage")));
            this.NewMailbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NewMailbtn.Location = new System.Drawing.Point(41, 1);
            this.NewMailbtn.Name = "NewMailbtn";
            this.NewMailbtn.Size = new System.Drawing.Size(32, 32);
            this.NewMailbtn.TabIndex = 16;
            this.NewMailbtn.UseVisualStyleBackColor = true;
            this.NewMailbtn.Click += new System.EventHandler(this.NewMailbtn_Click);
            // 
            // Settingsbtn
            // 
            this.Settingsbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Settingsbtn.BackgroundImage")));
            this.Settingsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Settingsbtn.Location = new System.Drawing.Point(807, 1);
            this.Settingsbtn.Name = "Settingsbtn";
            this.Settingsbtn.Size = new System.Drawing.Size(32, 32);
            this.Settingsbtn.TabIndex = 17;
            this.Settingsbtn.UseVisualStyleBackColor = true;
            this.Settingsbtn.Click += new System.EventHandler(this.Settingsbtn_Click);
            // 
            // EmailClient_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 537);
            this.Controls.Add(this.Settingsbtn);
            this.Controls.Add(this.NewMailbtn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pbxWorking);
            this.Controls.Add(this.msgBodytbx);
            this.Controls.Add(this.subjectlsbx);
            this.Controls.Add(this.msgcounglb);
            this.Controls.Add(this.ReciveMailbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmailClient_form";
            this.Text = "Ema!l Client";
            ((System.ComponentModel.ISupportInitialize)(this.pbxWorking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pbxWorking;
        private System.Windows.Forms.RichTextBox msgBodytbx;
        private System.Windows.Forms.ListBox subjectlsbx;
        private System.Windows.Forms.Label msgcounglb;
        private System.Windows.Forms.Button ReciveMailbtn;
        private System.ComponentModel.BackgroundWorker worker;
        private System.Windows.Forms.Button NewMailbtn;
        private System.Windows.Forms.Button Settingsbtn;

    }
}

