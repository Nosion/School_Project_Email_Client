namespace EmailClient
{
    partial class RecieveMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecieveMail));
            this.ReciveMailbtn = new System.Windows.Forms.Button();
            this.msgcounglb = new System.Windows.Forms.Label();
            this.Subjectlsbx = new System.Windows.Forms.ListBox();
            this.msgBodytbx = new System.Windows.Forms.RichTextBox();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.pbxWorking = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWorking)).BeginInit();
            this.SuspendLayout();
            // 
            // ReciveMailbtn
            // 
            this.ReciveMailbtn.Location = new System.Drawing.Point(26, 13);
            this.ReciveMailbtn.Name = "ReciveMailbtn";
            this.ReciveMailbtn.Size = new System.Drawing.Size(75, 23);
            this.ReciveMailbtn.TabIndex = 0;
            this.ReciveMailbtn.Text = "Recive";
            this.ReciveMailbtn.UseVisualStyleBackColor = true;
            this.ReciveMailbtn.Click += new System.EventHandler(this.ReciveMailbtn_Click);
            // 
            // msgcounglb
            // 
            this.msgcounglb.AutoSize = true;
            this.msgcounglb.Location = new System.Drawing.Point(519, 23);
            this.msgcounglb.Name = "msgcounglb";
            this.msgcounglb.Size = new System.Drawing.Size(27, 13);
            this.msgcounglb.TabIndex = 3;
            this.msgcounglb.Text = "N/A";
            // 
            // Subjectlsbx
            // 
            this.Subjectlsbx.FormattingEnabled = true;
            this.Subjectlsbx.Location = new System.Drawing.Point(12, 42);
            this.Subjectlsbx.Name = "Subjectlsbx";
            this.Subjectlsbx.Size = new System.Drawing.Size(150, 368);
            this.Subjectlsbx.TabIndex = 4;
            this.Subjectlsbx.SelectedIndexChanged += new System.EventHandler(this.Subjectlsbx_SelectedIndexChanged);
            // 
            // msgBodytbx
            // 
            this.msgBodytbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msgBodytbx.Location = new System.Drawing.Point(168, 42);
            this.msgBodytbx.Name = "msgBodytbx";
            this.msgBodytbx.Size = new System.Drawing.Size(415, 368);
            this.msgBodytbx.TabIndex = 5;
            this.msgBodytbx.Text = "";
            // 
            // pbxWorking
            // 
            this.pbxWorking.Image = ((System.Drawing.Image)(resources.GetObject("pbxWorking.Image")));
            this.pbxWorking.Location = new System.Drawing.Point(552, 15);
            this.pbxWorking.Name = "pbxWorking";
            this.pbxWorking.Size = new System.Drawing.Size(21, 21);
            this.pbxWorking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxWorking.TabIndex = 6;
            this.pbxWorking.TabStop = false;
            this.pbxWorking.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(61, 433);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(409, 14);
            this.progressBar1.TabIndex = 7;
            // 
            // RecieveMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 474);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pbxWorking);
            this.Controls.Add(this.msgBodytbx);
            this.Controls.Add(this.Subjectlsbx);
            this.Controls.Add(this.msgcounglb);
            this.Controls.Add(this.ReciveMailbtn);
            this.Name = "RecieveMail";
            this.Text = "RecieveMail";
            ((System.ComponentModel.ISupportInitialize)(this.pbxWorking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReciveMailbtn;
        private System.Windows.Forms.Label msgcounglb;
        private System.Windows.Forms.ListBox Subjectlsbx;
        private System.Windows.Forms.RichTextBox msgBodytbx;
        private System.ComponentModel.BackgroundWorker worker;
        private System.Windows.Forms.PictureBox pbxWorking;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}