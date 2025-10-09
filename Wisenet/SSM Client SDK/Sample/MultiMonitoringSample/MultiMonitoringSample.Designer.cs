namespace MultiMonitoring
{
    partial class MultiMonitoringSample
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
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.grpLiveControl = new System.Windows.Forms.GroupBox();
            this.cbxCameras = new System.Windows.Forms.ComboBox();
            this.lblCamera = new System.Windows.Forms.Label();
            this.listViewUrl = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDevice = new System.Windows.Forms.Label();
            this.cbxDevices = new System.Windows.Forms.ComboBox();
            this.btnGetRtspUrl = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.clearLog = new System.Windows.Forms.Button();
            this.columnGuid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpLoginInfo.SuspendLayout();
            this.grpLiveControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            this.grpLoginInfo.Location = new System.Drawing.Point(512, 12);
            this.grpLoginInfo.Name = "grpLoginInfo";
            this.grpLoginInfo.Size = new System.Drawing.Size(426, 164);
            this.grpLoginInfo.TabIndex = 9;
            this.grpLoginInfo.TabStop = false;
            this.grpLoginInfo.Text = "Login";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(338, 130);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(76, 23);
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
            this.btnLogin.Location = new System.Drawing.Point(256, 130);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(76, 23);
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
            this.txtPort.Location = new System.Drawing.Point(173, 103);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(241, 21);
            this.txtPort.TabIndex = 10;
            this.txtPort.Text = "9999";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(173, 76);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(241, 21);
            this.txtIPAddress.TabIndex = 9;
            this.txtIPAddress.Text = "127.0.0.1";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(173, 48);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(241, 21);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "init123!!";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(173, 20);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(241, 21);
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
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(10, 398);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStatus.Size = new System.Drawing.Size(486, 150);
            this.txtStatus.TabIndex = 32;
            // 
            // grpLiveControl
            // 
            this.grpLiveControl.Controls.Add(this.cbxCameras);
            this.grpLiveControl.Controls.Add(this.lblCamera);
            this.grpLiveControl.Controls.Add(this.listViewUrl);
            this.grpLiveControl.Controls.Add(this.lblDevice);
            this.grpLiveControl.Controls.Add(this.cbxDevices);
            this.grpLiveControl.Controls.Add(this.btnGetRtspUrl);
            this.grpLiveControl.Controls.Add(this.btnClose);
            this.grpLiveControl.Controls.Add(this.btnOpen);
            this.grpLiveControl.Location = new System.Drawing.Point(512, 182);
            this.grpLiveControl.Name = "grpLiveControl";
            this.grpLiveControl.Size = new System.Drawing.Size(426, 366);
            this.grpLiveControl.TabIndex = 33;
            this.grpLiveControl.TabStop = false;
            this.grpLiveControl.Text = "Live Control";
            // 
            // cbxCameras
            // 
            this.cbxCameras.BackColor = System.Drawing.SystemColors.Window;
            this.cbxCameras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCameras.FormattingEnabled = true;
            this.cbxCameras.Location = new System.Drawing.Point(149, 46);
            this.cbxCameras.Name = "cbxCameras";
            this.cbxCameras.Size = new System.Drawing.Size(266, 20);
            this.cbxCameras.TabIndex = 61;
            this.cbxCameras.SelectedIndexChanged += new System.EventHandler(this.cbxCameras_SelectedIndexChanged);
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.Location = new System.Drawing.Point(6, 49);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(50, 12);
            this.lblCamera.TabIndex = 60;
            this.lblCamera.Text = "Camera";
            // 
            // listViewUrl
            // 
            this.listViewUrl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderUrl,
            this.columnGuid});
            this.listViewUrl.Location = new System.Drawing.Point(6, 130);
            this.listViewUrl.Name = "listViewUrl";
            this.listViewUrl.Size = new System.Drawing.Size(409, 178);
            this.listViewUrl.TabIndex = 34;
            this.listViewUrl.UseCompatibleStateImageBehavior = false;
            this.listViewUrl.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 80;
            // 
            // columnHeaderUrl
            // 
            this.columnHeaderUrl.Text = "URL";
            this.columnHeaderUrl.Width = 250;
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(6, 23);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(43, 12);
            this.lblDevice.TabIndex = 59;
            this.lblDevice.Text = "Device";
            // 
            // cbxDevices
            // 
            this.cbxDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDevices.FormattingEnabled = true;
            this.cbxDevices.Location = new System.Drawing.Point(149, 20);
            this.cbxDevices.Name = "cbxDevices";
            this.cbxDevices.Size = new System.Drawing.Size(266, 20);
            this.cbxDevices.TabIndex = 58;
            this.cbxDevices.SelectedIndexChanged += new System.EventHandler(this.cbxDevices_SelectedIndexChanged);
            // 
            // btnGetRtspUrl
            // 
            this.btnGetRtspUrl.Location = new System.Drawing.Point(256, 72);
            this.btnGetRtspUrl.Name = "btnGetRtspUrl";
            this.btnGetRtspUrl.Size = new System.Drawing.Size(159, 23);
            this.btnGetRtspUrl.TabIndex = 14;
            this.btnGetRtspUrl.Text = "Get URL";
            this.btnGetRtspUrl.UseVisualStyleBackColor = true;
            this.btnGetRtspUrl.Click += new System.EventHandler(this.btnGetRtspUrl_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(339, 328);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(256, 328);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(76, 23);
            this.btnOpen.TabIndex = 12;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 373);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 12);
            this.lblStatus.TabIndex = 62;
            this.lblStatus.Text = "Status";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(261, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(235, 164);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(14, 187);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(235, 164);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 65;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(261, 188);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(235, 164);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 66;
            this.pictureBox4.TabStop = false;
            // 
            // clearLog
            // 
            this.clearLog.Location = new System.Drawing.Point(423, 367);
            this.clearLog.Name = "clearLog";
            this.clearLog.Size = new System.Drawing.Size(73, 25);
            this.clearLog.TabIndex = 67;
            this.clearLog.Text = "Clear";
            this.clearLog.UseVisualStyleBackColor = true;
            this.clearLog.Click += new System.EventHandler(this.clearLog_Click);
            // 
            // columnGuid
            // 
            this.columnGuid.Text = "Guid";
            this.columnGuid.Width = 200;
            // 
            // MultiMonitoringSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 564);
            this.Controls.Add(this.clearLog);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.grpLiveControl);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.grpLoginInfo);
            this.Name = "MultiMonitoringSample";
            this.Text = "MultiMonitoring";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MultiMonitoring_Closing);
            this.Load += new System.EventHandler(this.MultiMonitoring_Load);
            this.grpLoginInfo.ResumeLayout(false);
            this.grpLoginInfo.PerformLayout();
            this.grpLiveControl.ResumeLayout(false);
            this.grpLiveControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.GroupBox grpLiveControl;
        private System.Windows.Forms.Button btnGetRtspUrl;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.ComboBox cbxDevices;
        private System.Windows.Forms.ListView listViewUrl;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderUrl;
        private System.Windows.Forms.ComboBox cbxCameras;
        private System.Windows.Forms.Label lblCamera;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button clearLog;
        private System.Windows.Forms.ColumnHeader columnGuid;
    }
}