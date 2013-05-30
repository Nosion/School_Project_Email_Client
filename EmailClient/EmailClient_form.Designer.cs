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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recievedMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pbxWorking = new System.Windows.Forms.PictureBox();
            this.msgBodytbx = new System.Windows.Forms.RichTextBox();
            this.subjectlsbx = new System.Windows.Forms.ListBox();
            this.msgcounglb = new System.Windows.Forms.Label();
            this.ReciveMailbtn = new System.Windows.Forms.Button();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWorking)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(885, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMailToolStripMenuItem,
            this.recievedMailToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newMailToolStripMenuItem
            // 
            this.newMailToolStripMenuItem.Name = "newMailToolStripMenuItem";
            this.newMailToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.newMailToolStripMenuItem.Text = "New Mail";
            this.newMailToolStripMenuItem.Click += new System.EventHandler(this.newMailToolStripMenuItem_Click);
            // 
            // recievedMailToolStripMenuItem
            // 
            this.recievedMailToolStripMenuItem.Name = "recievedMailToolStripMenuItem";
            this.recievedMailToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.recievedMailToolStripMenuItem.Text = "Recieved Mail";
            this.recievedMailToolStripMenuItem.Click += new System.EventHandler(this.recievedMailToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 610);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(409, 14);
            this.progressBar1.TabIndex = 13;
            // 
            // pbxWorking
            // 
            this.pbxWorking.Image = ((System.Drawing.Image)(resources.GetObject("pbxWorking.Image")));
            this.pbxWorking.Location = new System.Drawing.Point(86, 583);
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
            this.msgBodytbx.Location = new System.Drawing.Point(333, 40);
            this.msgBodytbx.Name = "msgBodytbx";
            this.msgBodytbx.Size = new System.Drawing.Size(526, 524);
            this.msgBodytbx.TabIndex = 11;
            this.msgBodytbx.Text = "";
            // 
            // subjectlsbx
            // 
            this.subjectlsbx.FormattingEnabled = true;
            this.subjectlsbx.Location = new System.Drawing.Point(166, 40);
            this.subjectlsbx.Name = "subjectlsbx";
            this.subjectlsbx.Size = new System.Drawing.Size(150, 524);
            this.subjectlsbx.TabIndex = 10;
            this.subjectlsbx.SelectedIndexChanged += new System.EventHandler(this.subjectlsbx_SelectedIndexChanged_1);
            // 
            // msgcounglb
            // 
            this.msgcounglb.AutoSize = true;
            this.msgcounglb.Location = new System.Drawing.Point(12, 591);
            this.msgcounglb.Name = "msgcounglb";
            this.msgcounglb.Size = new System.Drawing.Size(27, 13);
            this.msgcounglb.TabIndex = 9;
            this.msgcounglb.Text = "N/A";
            // 
            // ReciveMailbtn
            // 
            this.ReciveMailbtn.Location = new System.Drawing.Point(12, 27);
            this.ReciveMailbtn.Name = "ReciveMailbtn";
            this.ReciveMailbtn.Size = new System.Drawing.Size(75, 23);
            this.ReciveMailbtn.TabIndex = 8;
            this.ReciveMailbtn.Text = "Recive";
            this.ReciveMailbtn.UseVisualStyleBackColor = true;
            this.ReciveMailbtn.Click += new System.EventHandler(this.ReciveMailbtn_Click_1);
            // 
            // EmailClient_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 626);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pbxWorking);
            this.Controls.Add(this.msgBodytbx);
            this.Controls.Add(this.subjectlsbx);
            this.Controls.Add(this.msgcounglb);
            this.Controls.Add(this.ReciveMailbtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EmailClient_form";
            this.Text = "BUG Email Client";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWorking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newMailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recievedMailToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pbxWorking;
        private System.Windows.Forms.RichTextBox msgBodytbx;
        private System.Windows.Forms.ListBox subjectlsbx;
        private System.Windows.Forms.Label msgcounglb;
        private System.Windows.Forms.Button ReciveMailbtn;
        private System.ComponentModel.BackgroundWorker worker;

    }
}

