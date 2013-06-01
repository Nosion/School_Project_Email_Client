namespace EmailClient
{
    partial class Settings_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings_form));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pbxAuthOk = new System.Windows.Forms.PictureBox();
            this.lbAuth = new System.Windows.Forms.Label();
            this.pbxAuthFail = new System.Windows.Forms.PictureBox();
            this.lbCurrentUsr = new System.Windows.Forms.Label();
            this.lbCurrent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAuthOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAuthFail)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save user";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbxAuthOk
            // 
            this.pbxAuthOk.Image = ((System.Drawing.Image)(resources.GetObject("pbxAuthOk.Image")));
            this.pbxAuthOk.Location = new System.Drawing.Point(49, 159);
            this.pbxAuthOk.Name = "pbxAuthOk";
            this.pbxAuthOk.Size = new System.Drawing.Size(32, 32);
            this.pbxAuthOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxAuthOk.TabIndex = 5;
            this.pbxAuthOk.TabStop = false;
            this.pbxAuthOk.Visible = false;
            // 
            // lbAuth
            // 
            this.lbAuth.AutoSize = true;
            this.lbAuth.Location = new System.Drawing.Point(81, 194);
            this.lbAuth.Name = "lbAuth";
            this.lbAuth.Size = new System.Drawing.Size(0, 13);
            this.lbAuth.TabIndex = 6;
            // 
            // pbxAuthFail
            // 
            this.pbxAuthFail.Image = ((System.Drawing.Image)(resources.GetObject("pbxAuthFail.Image")));
            this.pbxAuthFail.Location = new System.Drawing.Point(49, 194);
            this.pbxAuthFail.Name = "pbxAuthFail";
            this.pbxAuthFail.Size = new System.Drawing.Size(32, 32);
            this.pbxAuthFail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxAuthFail.TabIndex = 7;
            this.pbxAuthFail.TabStop = false;
            this.pbxAuthFail.Visible = false;
            // 
            // lbCurrentUsr
            // 
            this.lbCurrentUsr.AutoSize = true;
            this.lbCurrentUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentUsr.Location = new System.Drawing.Point(128, 14);
            this.lbCurrentUsr.Name = "lbCurrentUsr";
            this.lbCurrentUsr.Size = new System.Drawing.Size(0, 20);
            this.lbCurrentUsr.TabIndex = 8;
            // 
            // lbCurrent
            // 
            this.lbCurrent.AutoSize = true;
            this.lbCurrent.Location = new System.Drawing.Point(7, 21);
            this.lbCurrent.Name = "lbCurrent";
            this.lbCurrent.Size = new System.Drawing.Size(99, 13);
            this.lbCurrent.TabIndex = 10;
            this.lbCurrent.Text = "Current user saved:";
            // 
            // Settings_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 249);
            this.Controls.Add(this.lbCurrent);
            this.Controls.Add(this.lbCurrentUsr);
            this.Controls.Add(this.pbxAuthFail);
            this.Controls.Add(this.lbAuth);
            this.Controls.Add(this.pbxAuthOk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Settings_form";
            this.Text = "Settings_form";
            ((System.ComponentModel.ISupportInitialize)(this.pbxAuthOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAuthFail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbxAuthOk;
        private System.Windows.Forms.Label lbAuth;
        private System.Windows.Forms.PictureBox pbxAuthFail;
        private System.Windows.Forms.Label lbCurrentUsr;
        private System.Windows.Forms.Label lbCurrent;
    }
}