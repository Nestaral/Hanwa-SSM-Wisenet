namespace LiveLocalRecordSample
{
    partial class LiveLocalRecordSample
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
            this.grpLoginInfo = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.textBoxUnitID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRecordStop = new System.Windows.Forms.Button();
            this.btnRecordStart = new System.Windows.Forms.Button();
            this.clearLog = new System.Windows.Forms.Button();
            this.grpLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLoginInfo
            // 
            this.grpLoginInfo.Controls.Add(this.btnLogout);
            this.grpLoginInfo.Controls.Add(this.lblPort);
            this.grpLoginInfo.Controls.Add(this.lblIPAddress);
            this.grpLoginInfo.Controls.Add(this.btnLogin);
            this.grpLoginInfo.Controls.Add(this.lblPassword);
            this.grpLoginInfo.Controls.Add(this.txtPort);
            this.grpLoginInfo.Controls.Add(this.txtIPAddress);
            this.grpLoginInfo.Controls.Add(this.txtPassword);
            this.grpLoginInfo.Controls.Add(this.txtID);
            this.grpLoginInfo.Controls.Add(this.lblID);
            this.grpLoginInfo.Location = new System.Drawing.Point(14, 12);
            this.grpLoginInfo.Name = "grpLoginInfo";
            this.grpLoginInfo.Size = new System.Drawing.Size(403, 174);
            this.grpLoginInfo.TabIndex = 32;
            this.grpLoginInfo.TabStop = false;
            this.grpLoginInfo.Text = "Login";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(309, 130);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(88, 36);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(6, 106);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(90, 12);
            this.lblPort.TabIndex = 13;
            this.lblPort.Text = "SM Server Port";
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Location = new System.Drawing.Point(6, 79);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(79, 12);
            this.lblIPAddress.TabIndex = 12;
            this.lblIPAddress.Text = "SM Server IP";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(215, 130);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(88, 36);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 51);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(62, 12);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(103, 103);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(294, 21);
            this.txtPort.TabIndex = 10;
            this.txtPort.Text = "9999";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(103, 76);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(294, 21);
            this.txtIPAddress.TabIndex = 9;
            this.txtIPAddress.Text = "127.0.0.1";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(103, 48);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(294, 21);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "init123!!";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(103, 20);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(294, 21);
            this.txtID.TabIndex = 7;
            this.txtID.Text = "admin";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 24);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(16, 12);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 397);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(399, 177);
            this.txtLog.TabIndex = 33;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(12, 372);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(26, 12);
            this.lblLog.TabIndex = 34;
            this.lblLog.Text = "Log";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(156, 253);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(255, 21);
            this.textBoxFilePath.TabIndex = 37;
            this.textBoxFilePath.Text = "C:\\";
            // 
            // textBoxUnitID
            // 
            this.textBoxUnitID.Location = new System.Drawing.Point(156, 226);
            this.textBoxUnitID.Name = "textBoxUnitID";
            this.textBoxUnitID.Size = new System.Drawing.Size(255, 21);
            this.textBoxUnitID.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 12);
            this.label6.TabIndex = 39;
            this.label6.Text = "Path";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 12);
            this.label5.TabIndex = 40;
            this.label5.Text = "Camera Guid";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(156, 280);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(255, 21);
            this.textBoxFileName.TabIndex = 44;
            this.textBoxFileName.Text = "Record.avi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 12);
            this.label9.TabIndex = 43;
            this.label9.Text = "File name";
            // 
            // btnRecordStop
            // 
            this.btnRecordStop.Location = new System.Drawing.Point(309, 314);
            this.btnRecordStop.Name = "btnRecordStop";
            this.btnRecordStop.Size = new System.Drawing.Size(102, 36);
            this.btnRecordStop.TabIndex = 41;
            this.btnRecordStop.Text = "Record Stop";
            this.btnRecordStop.UseVisualStyleBackColor = true;
            this.btnRecordStop.Click += new System.EventHandler(this.btnRecordStop_Click);
            // 
            // btnRecordStart
            // 
            this.btnRecordStart.Location = new System.Drawing.Point(195, 314);
            this.btnRecordStart.Name = "btnRecordStart";
            this.btnRecordStart.Size = new System.Drawing.Size(108, 36);
            this.btnRecordStart.TabIndex = 42;
            this.btnRecordStart.Text = "Record Start";
            this.btnRecordStart.UseVisualStyleBackColor = true;
            this.btnRecordStart.Click += new System.EventHandler(this.btnRecordStart_Click);
            // 
            // clearLog
            // 
            this.clearLog.Location = new System.Drawing.Point(338, 366);
            this.clearLog.Name = "clearLog";
            this.clearLog.Size = new System.Drawing.Size(73, 25);
            this.clearLog.TabIndex = 47;
            this.clearLog.Text = "Clear";
            this.clearLog.UseVisualStyleBackColor = true;
            this.clearLog.Click += new System.EventHandler(this.clearLog_Click);
            // 
            // LiveLocalRecordSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 586);
            this.Controls.Add(this.clearLog);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRecordStop);
            this.Controls.Add(this.btnRecordStart);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.textBoxUnitID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.grpLoginInfo);
            this.Name = "LiveLocalRecordSample";
            this.Text = "LiveLocalRecord Sample";
            this.Closed += new System.EventHandler(this.LiveLocalRecordSample_Closed);
            this.Load += new System.EventHandler(this.LiveLocalRecordSample_Load);
            this.grpLoginInfo.ResumeLayout(false);
            this.grpLoginInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLoginInfo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.TextBox textBoxUnitID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRecordStop;
        private System.Windows.Forms.Button btnRecordStart;
        private System.Windows.Forms.Button clearLog;
    }
}