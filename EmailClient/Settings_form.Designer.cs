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
            this.components = new System.ComponentModel.Container();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbobxChooseLang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAuthOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAuthFail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbxAuthOk
            // 
            resources.ApplyResources(this.pbxAuthOk, "pbxAuthOk");
            this.pbxAuthOk.Name = "pbxAuthOk";
            this.pbxAuthOk.TabStop = false;
            // 
            // lbAuth
            // 
            resources.ApplyResources(this.lbAuth, "lbAuth");
            this.lbAuth.Name = "lbAuth";
            // 
            // pbxAuthFail
            // 
            resources.ApplyResources(this.pbxAuthFail, "pbxAuthFail");
            this.pbxAuthFail.Name = "pbxAuthFail";
            this.pbxAuthFail.TabStop = false;
            // 
            // lbCurrentUsr
            // 
            resources.ApplyResources(this.lbCurrentUsr, "lbCurrentUsr");
            this.lbCurrentUsr.Name = "lbCurrentUsr";
            // 
            // lbCurrent
            // 
            resources.ApplyResources(this.lbCurrent, "lbCurrent");
            this.lbCurrent.Name = "lbCurrent";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbobxChooseLang);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // cmbobxChooseLang
            // 
            this.cmbobxChooseLang.FormattingEnabled = true;
            resources.ApplyResources(this.cmbobxChooseLang, "cmbobxChooseLang");
            this.cmbobxChooseLang.Name = "cmbobxChooseLang";
            // 
            // Settings_form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbxAuthOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAuthFail)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cmbobxChooseLang;
    }
}