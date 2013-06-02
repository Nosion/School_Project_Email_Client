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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWorking)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // pbxWorking
            // 
            resources.ApplyResources(this.pbxWorking, "pbxWorking");
            this.pbxWorking.Name = "pbxWorking";
            this.pbxWorking.TabStop = false;
            // 
            // msgBodytbx
            // 
            resources.ApplyResources(this.msgBodytbx, "msgBodytbx");
            this.msgBodytbx.Name = "msgBodytbx";
            // 
            // subjectlsbx
            // 
            resources.ApplyResources(this.subjectlsbx, "subjectlsbx");
            this.subjectlsbx.FormattingEnabled = true;
            this.subjectlsbx.Name = "subjectlsbx";
            this.subjectlsbx.SelectedIndexChanged += new System.EventHandler(this.subjectlsbx_SelectedIndexChanged_1);
            // 
            // msgcounglb
            // 
            resources.ApplyResources(this.msgcounglb, "msgcounglb");
            this.msgcounglb.Name = "msgcounglb";
            // 
            // ReciveMailbtn
            // 
            resources.ApplyResources(this.ReciveMailbtn, "ReciveMailbtn");
            this.ReciveMailbtn.Name = "ReciveMailbtn";
            this.ReciveMailbtn.UseVisualStyleBackColor = true;
            this.ReciveMailbtn.Click += new System.EventHandler(this.ReciveMailbtn_Click_1);
            // 
            // NewMailbtn
            // 
            resources.ApplyResources(this.NewMailbtn, "NewMailbtn");
            this.NewMailbtn.Name = "NewMailbtn";
            this.NewMailbtn.UseVisualStyleBackColor = true;
            this.NewMailbtn.Click += new System.EventHandler(this.NewMailbtn_Click);
            // 
            // Settingsbtn
            // 
            resources.ApplyResources(this.Settingsbtn, "Settingsbtn");
            this.Settingsbtn.Name = "Settingsbtn";
            this.Settingsbtn.UseVisualStyleBackColor = true;
            this.Settingsbtn.Click += new System.EventHandler(this.Settingsbtn_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EmailClient_form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Settingsbtn);
            this.Controls.Add(this.NewMailbtn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pbxWorking);
            this.Controls.Add(this.msgBodytbx);
            this.Controls.Add(this.subjectlsbx);
            this.Controls.Add(this.msgcounglb);
            this.Controls.Add(this.ReciveMailbtn);
            this.Name = "EmailClient_form";
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
        private System.Windows.Forms.Button button1;

    }
}

