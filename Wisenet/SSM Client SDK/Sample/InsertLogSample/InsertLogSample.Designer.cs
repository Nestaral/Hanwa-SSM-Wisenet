namespace InsertLogSample
{
    partial class InsertLogSample
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
            this.grpLogInInfo = new System.Windows.Forms.GroupBox();
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpLogControl = new System.Windows.Forms.GroupBox();
            this.lblDevice = new System.Windows.Forms.Label();
            this.cbxDevices = new System.Windows.Forms.ComboBox();
            this.cbxCameras = new System.Windows.Forms.ComboBox();
            this.lblCamera = new System.Windows.Forms.Label();
            this.lblLogType = new System.Windows.Forms.Label();
            this.btnInsertLog = new System.Windows.Forms.Button();
            this.cbxLogType = new System.Windows.Forms.ComboBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.clearLog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEventKey = new System.Windows.Forms.TextBox();
            this.btnInsertLogWithEventKey = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEventLog = new System.Windows.Forms.TextBox();
            this.grpLogInInfo.SuspendLayout();
            this.grpLogControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLogInInfo
            // 
            this.grpLogInInfo.Controls.Add(this.btnLogout);
            this.grpLogInInfo.Controls.Add(this.lblPort);
            this.grpLogInInfo.Controls.Add(this.lblIPAddress);
            this.grpLogInInfo.Controls.Add(this.btnLogin);
            this.grpLogInInfo.Controls.Add(this.lblPassword);
            this.grpLogInInfo.Controls.Add(this.txtPort);
            this.grpLogInInfo.Controls.Add(this.txtIPAddress);
            this.grpLogInInfo.Controls.Add(this.txtPassword);
            this.grpLogInInfo.Controls.Add(this.txtID);
            this.grpLogInInfo.Controls.Add(this.lblID);
            this.grpLogInInfo.Location = new System.Drawing.Point(17, 18);
            this.grpLogInInfo.Margin = new System.Windows.Forms.Padding(4);
            this.grpLogInInfo.Name = "grpLogInInfo";
            this.grpLogInInfo.Padding = new System.Windows.Forms.Padding(4);
            this.grpLogInInfo.Size = new System.Drawing.Size(477, 240);
            this.grpLogInInfo.TabIndex = 33;
            this.grpLogInInfo.TabStop = false;
            this.grpLogInInfo.Text = "LogIn";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(361, 195);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(107, 34);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(9, 159);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(132, 18);
            this.lblPort.TabIndex = 13;
            this.lblPort.Text = "SM Server Port";
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Location = new System.Drawing.Point(9, 118);
            this.lblIPAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(113, 18);
            this.lblIPAddress.TabIndex = 12;
            this.lblIPAddress.Text = "SM Server IP";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(246, 195);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(107, 34);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "LogIn";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(9, 76);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(90, 18);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(147, 154);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(320, 28);
            this.txtPort.TabIndex = 10;
            this.txtPort.Text = "9999";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(147, 114);
            this.txtIPAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(320, 28);
            this.txtIPAddress.TabIndex = 9;
            this.txtIPAddress.Text = "127.0.0.1";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(147, 72);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(320, 28);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "init123!!";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(147, 30);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(320, 28);
            this.txtID.TabIndex = 7;
            this.txtID.Text = "admin";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(9, 36);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(22, 18);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 705);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(59, 18);
            this.lblStatus.TabIndex = 36;
            this.lblStatus.Text = "Status";
            // 
            // grpLogControl
            // 
            this.grpLogControl.Controls.Add(this.lblDevice);
            this.grpLogControl.Controls.Add(this.cbxDevices);
            this.grpLogControl.Controls.Add(this.cbxCameras);
            this.grpLogControl.Controls.Add(this.lblCamera);
            this.grpLogControl.Location = new System.Drawing.Point(17, 267);
            this.grpLogControl.Margin = new System.Windows.Forms.Padding(4);
            this.grpLogControl.Name = "grpLogControl";
            this.grpLogControl.Padding = new System.Windows.Forms.Padding(4);
            this.grpLogControl.Size = new System.Drawing.Size(477, 110);
            this.grpLogControl.TabIndex = 37;
            this.grpLogControl.TabStop = false;
            this.grpLogControl.Text = "Device info";
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(9, 34);
            this.lblDevice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(62, 18);
            this.lblDevice.TabIndex = 57;
            this.lblDevice.Text = "Device";
            // 
            // cbxDevices
            // 
            this.cbxDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDevices.FormattingEnabled = true;
            this.cbxDevices.Location = new System.Drawing.Point(147, 30);
            this.cbxDevices.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDevices.Name = "cbxDevices";
            this.cbxDevices.Size = new System.Drawing.Size(314, 26);
            this.cbxDevices.TabIndex = 56;
            this.cbxDevices.SelectedIndexChanged += new System.EventHandler(this.cbxDevices_SelectedIndexChanged);
            // 
            // cbxCameras
            // 
            this.cbxCameras.BackColor = System.Drawing.SystemColors.Window;
            this.cbxCameras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCameras.FormattingEnabled = true;
            this.cbxCameras.Location = new System.Drawing.Point(147, 69);
            this.cbxCameras.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCameras.Name = "cbxCameras";
            this.cbxCameras.Size = new System.Drawing.Size(314, 26);
            this.cbxCameras.TabIndex = 55;
            this.cbxCameras.SelectedIndexChanged += new System.EventHandler(this.cbxCameras_SelectedIndexChanged);
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.Location = new System.Drawing.Point(9, 74);
            this.lblCamera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(71, 18);
            this.lblCamera.TabIndex = 54;
            this.lblCamera.Text = "Camera";
            // 
            // lblLogType
            // 
            this.lblLogType.AutoSize = true;
            this.lblLogType.Location = new System.Drawing.Point(9, 26);
            this.lblLogType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogType.Name = "lblLogType";
            this.lblLogType.Size = new System.Drawing.Size(74, 18);
            this.lblLogType.TabIndex = 38;
            this.lblLogType.Text = "Event ID";
            // 
            // btnInsertLog
            // 
            this.btnInsertLog.Location = new System.Drawing.Point(316, 60);
            this.btnInsertLog.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertLog.Name = "btnInsertLog";
            this.btnInsertLog.Size = new System.Drawing.Size(144, 34);
            this.btnInsertLog.TabIndex = 0;
            this.btnInsertLog.Text = "Send event";
            this.btnInsertLog.UseVisualStyleBackColor = true;
            this.btnInsertLog.Click += new System.EventHandler(this.btnInsertLog_Click);
            // 
            // cbxLogType
            // 
            this.cbxLogType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLogType.FormattingEnabled = true;
            this.cbxLogType.Items.AddRange(new object[] {
            "MOTION_DETECT",
            "ASSET_PROTECTION (Agent VI)",
            "CAMERA_TEMPERING (Agent VI)",
            "CROWD_DETECTION (Agent VI)",
            "LOITERING (Agent VI)",
            "OCCUPANCY (Agent VI)",
            "STERILE_ZONE (Agent VI)",
            "STOPPED_VEHICLE (Agent VI)",
            "SUSPICIOUS_OBJECT (Agent VI)",
            "THERMAL_CAMERA (Agent VI)",
            "VEHICLE_TAILGATING (Agent VI)",
            "INTRUSION_DETECT",
            "CROWD_DETECTION",
            "FOG_DETECTION"});
            this.cbxLogType.Location = new System.Drawing.Point(144, 21);
            this.cbxLogType.Margin = new System.Windows.Forms.Padding(4);
            this.cbxLogType.Name = "cbxLogType";
            this.cbxLogType.Size = new System.Drawing.Size(314, 26);
            this.cbxLogType.TabIndex = 2;
            this.cbxLogType.SelectedIndexChanged += new System.EventHandler(this.cbxLogType_SelectedIndexChanged);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(17, 736);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStatus.Size = new System.Drawing.Size(475, 232);
            this.txtStatus.TabIndex = 35;
            // 
            // clearLog
            // 
            this.clearLog.Location = new System.Drawing.Point(390, 673);
            this.clearLog.Margin = new System.Windows.Forms.Padding(4);
            this.clearLog.Name = "clearLog";
            this.clearLog.Size = new System.Drawing.Size(104, 38);
            this.clearLog.TabIndex = 46;
            this.clearLog.Text = "Clear";
            this.clearLog.UseVisualStyleBackColor = true;
            this.clearLog.Click += new System.EventHandler(this.clearLog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "Event Key";
            // 
            // txtEventKey
            // 
            this.txtEventKey.Location = new System.Drawing.Point(211, 21);
            this.txtEventKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtEventKey.Name = "txtEventKey";
            this.txtEventKey.Size = new System.Drawing.Size(247, 28);
            this.txtEventKey.TabIndex = 10;
            this.txtEventKey.Text = "10001";
            // 
            // btnInsertLogWithEventKey
            // 
            this.btnInsertLogWithEventKey.Location = new System.Drawing.Point(314, 112);
            this.btnInsertLogWithEventKey.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertLogWithEventKey.Name = "btnInsertLogWithEventKey";
            this.btnInsertLogWithEventKey.Size = new System.Drawing.Size(144, 34);
            this.btnInsertLogWithEventKey.TabIndex = 0;
            this.btnInsertLogWithEventKey.Text = "Send event";
            this.btnInsertLogWithEventKey.UseVisualStyleBackColor = true;
            this.btnInsertLogWithEventKey.Click += new System.EventHandler(this.btnInsertLogWithEventKey_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLogType);
            this.groupBox1.Controls.Add(this.cbxLogType);
            this.groupBox1.Controls.Add(this.btnInsertLog);
            this.groupBox1.Location = new System.Drawing.Point(20, 386);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(474, 105);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send with Event ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtEventLog);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtEventKey);
            this.groupBox2.Controls.Add(this.btnInsertLogWithEventKey);
            this.groupBox2.Location = new System.Drawing.Point(20, 500);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(474, 165);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send with Event Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Vehicle number(ANPR)";
            // 
            // txtEventLog
            // 
            this.txtEventLog.Location = new System.Drawing.Point(211, 62);
            this.txtEventLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtEventLog.Name = "txtEventLog";
            this.txtEventLog.Size = new System.Drawing.Size(247, 28);
            this.txtEventLog.TabIndex = 39;
            // 
            // InsertLogSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 981);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clearLog);
            this.Controls.Add(this.grpLogControl);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.grpLogInInfo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InsertLogSample";
            this.Text = "Insert Log Sample";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InsertLogSample_Closed);
            this.Load += new System.EventHandler(this.InsertLogSample_Load);
            this.grpLogInInfo.ResumeLayout(false);
            this.grpLogInInfo.PerformLayout();
            this.grpLogControl.ResumeLayout(false);
            this.grpLogControl.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLogInInfo;
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
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpLogControl;
        private System.Windows.Forms.Button btnInsertLog;
        private System.Windows.Forms.ComboBox cbxLogType;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.ComboBox cbxDevices;
        private System.Windows.Forms.ComboBox cbxCameras;
        private System.Windows.Forms.Label lblCamera;
        private System.Windows.Forms.Label lblLogType;
        private System.Windows.Forms.Button clearLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEventKey;
        private System.Windows.Forms.Button btnInsertLogWithEventKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEventLog;
        private System.Windows.Forms.Label label2;
    }
}