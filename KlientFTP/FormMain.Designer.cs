namespace KlientFTP
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxServer = new System.Windows.Forms.ComboBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxPass = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.textBoxLocalPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.listBoxFtpDir = new System.Windows.Forms.ListBox();
            this.textBoxFtpPath = new System.Windows.Forms.TextBox();
            this.buttonUpDir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDownload = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxServer
            // 
            this.comboBoxServer.FormattingEnabled = true;
            this.comboBoxServer.Location = new System.Drawing.Point(6, 21);
            this.comboBoxServer.Name = "comboBoxServer";
            this.comboBoxServer.Size = new System.Drawing.Size(260, 24);
            this.comboBoxServer.TabIndex = 0;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(76, 60);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(190, 22);
            this.textBoxLogin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login";
            // 
            // maskedTextBoxPass
            // 
            this.maskedTextBoxPass.Location = new System.Drawing.Point(76, 99);
            this.maskedTextBoxPass.Name = "maskedTextBoxPass";
            this.maskedTextBoxPass.PasswordChar = '*';
            this.maskedTextBoxPass.Size = new System.Drawing.Size(190, 22);
            this.maskedTextBoxPass.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(6, 148);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(79, 31);
            this.buttonConnect.TabIndex = 6;
            this.buttonConnect.Text = "Połącz";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(191, 148);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 31);
            this.buttonDisconnect.TabIndex = 7;
            this.buttonDisconnect.Text = "Rozłącz";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxServer);
            this.groupBox1.Controls.Add(this.buttonDisconnect);
            this.groupBox1.Controls.Add(this.textBoxLogin);
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.maskedTextBoxPass);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 194);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serwer FTP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonUpload);
            this.groupBox2.Controls.Add(this.buttonDownload);
            this.groupBox2.Location = new System.Drawing.Point(12, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 196);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opcje";
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(92, 41);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(88, 36);
            this.buttonDownload.TabIndex = 10;
            this.buttonDownload.Text = "Pobierz";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(92, 99);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(88, 36);
            this.buttonUpload.TabIndex = 11;
            this.buttonUpload.Text = "Wyślij";
            this.buttonUpload.UseVisualStyleBackColor = true;
            // 
            // textBoxLocalPath
            // 
            this.textBoxLocalPath.Location = new System.Drawing.Point(315, 33);
            this.textBoxLocalPath.Name = "textBoxLocalPath";
            this.textBoxLocalPath.Size = new System.Drawing.Size(399, 22);
            this.textBoxLocalPath.TabIndex = 10;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(720, 32);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(53, 25);
            this.buttonBrowse.TabIndex = 11;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // listBoxFtpDir
            // 
            this.listBoxFtpDir.FormattingEnabled = true;
            this.listBoxFtpDir.ItemHeight = 16;
            this.listBoxFtpDir.Location = new System.Drawing.Point(315, 75);
            this.listBoxFtpDir.Name = "listBoxFtpDir";
            this.listBoxFtpDir.Size = new System.Drawing.Size(473, 340);
            this.listBoxFtpDir.TabIndex = 12;
            this.listBoxFtpDir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxFtpDir_KeyDown);
            this.listBoxFtpDir.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxFtpDir_MouseDoubleClick);
            // 
            // textBoxFtpPath
            // 
            this.textBoxFtpPath.Location = new System.Drawing.Point(18, 436);
            this.textBoxFtpPath.Name = "textBoxFtpPath";
            this.textBoxFtpPath.Size = new System.Drawing.Size(696, 22);
            this.textBoxFtpPath.TabIndex = 13;
            // 
            // buttonUpDir
            // 
            this.buttonUpDir.Location = new System.Drawing.Point(721, 436);
            this.buttonUpDir.Name = "buttonUpDir";
            this.buttonUpDir.Size = new System.Drawing.Size(52, 22);
            this.buttonUpDir.TabIndex = 14;
            this.buttonUpDir.Text = "^";
            this.buttonUpDir.UseVisualStyleBackColor = true;
            this.buttonUpDir.Click += new System.EventHandler(this.buttonUpDir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelServer,
            this.toolStripStatusLabelDownload});
            this.statusStrip1.Location = new System.Drawing.Point(0, 474);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 25);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelServer
            // 
            this.toolStripStatusLabelServer.Name = "toolStripStatusLabelServer";
            this.toolStripStatusLabelServer.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabelServer.Text = "Serwer";
            // 
            // toolStripStatusLabelDownload
            // 
            this.toolStripStatusLabelDownload.Name = "toolStripStatusLabelDownload";
            this.toolStripStatusLabelDownload.Size = new System.Drawing.Size(0, 20);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonUpDir);
            this.Controls.Add(this.textBoxFtpPath);
            this.Controls.Add(this.listBoxFtpDir);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxLocalPath);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxServer;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.TextBox textBoxLocalPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.ListBox listBoxFtpDir;
        private System.Windows.Forms.TextBox textBoxFtpPath;
        private System.Windows.Forms.Button buttonUpDir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelServer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDownload;
    }
}

