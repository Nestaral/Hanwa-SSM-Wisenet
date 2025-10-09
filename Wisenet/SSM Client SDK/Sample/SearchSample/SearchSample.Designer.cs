namespace SearchSample
{
    partial class SearchSample
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
            this.grpLogControl = new System.Windows.Forms.GroupBox();
            this.btnSearchDay = new System.Windows.Forms.Button();
            this.btnSearchTrackID = new System.Windows.Forms.Button();
            this.btnSearchCalendar = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.btnReleaseAuthority = new System.Windows.Forms.Button();
            this.btnGetAuthority = new System.Windows.Forms.Button();
            this.lblDevice = new System.Windows.Forms.Label();
            this.cbxDevices = new System.Windows.Forms.ComboBox();
            this.cbxCameras = new System.Windows.Forms.ComboBox();
            this.lblCamera = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.clearLog = new System.Windows.Forms.Button();
            this.txtTrackID = new System.Windows.Forms.TextBox();
            this.lblTrackID = new System.Windows.Forms.Label();
            this.grpLogInInfo.SuspendLayout();
            this.grpLogControl.SuspendLayout();
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
            this.grpLogInInfo.Location = new System.Drawing.Point(12, 12);
            this.grpLogInInfo.Name = "grpLogInInfo";
            this.grpLogInInfo.Size = new System.Drawing.Size(334, 160);
            this.grpLogInInfo.TabIndex = 34;
            this.grpLogInInfo.TabStop = false;
            this.grpLogInInfo.Text = "LogIn";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(253, 130);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
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
            this.btnLogin.Location = new System.Drawing.Point(172, 130);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "LogIn";
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
            this.txtPort.Size = new System.Drawing.Size(225, 21);
            this.txtPort.TabIndex = 10;
            this.txtPort.Text = "9999";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(103, 76);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(225, 21);
            this.txtIPAddress.TabIndex = 9;
            this.txtIPAddress.Text = "127.0.0.1";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(103, 48);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(225, 21);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "init123!!";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(103, 20);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(225, 21);
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
            // grpLogControl
            // 
            this.grpLogControl.Controls.Add(this.lblTrackID);
            this.grpLogControl.Controls.Add(this.txtTrackID);
            this.grpLogControl.Controls.Add(this.btnSearchDay);
            this.grpLogControl.Controls.Add(this.btnSearchTrackID);
            this.grpLogControl.Controls.Add(this.btnSearchCalendar);
            this.grpLogControl.Controls.Add(this.monthCalendar);
            this.grpLogControl.Controls.Add(this.btnReleaseAuthority);
            this.grpLogControl.Controls.Add(this.btnGetAuthority);
            this.grpLogControl.Controls.Add(this.lblDevice);
            this.grpLogControl.Controls.Add(this.cbxDevices);
            this.grpLogControl.Controls.Add(this.cbxCameras);
            this.grpLogControl.Controls.Add(this.lblCamera);
            this.grpLogControl.Location = new System.Drawing.Point(352, 12);
            this.grpLogControl.Name = "grpLogControl";
            this.grpLogControl.Size = new System.Drawing.Size(311, 383);
            this.grpLogControl.TabIndex = 38;
            this.grpLogControl.TabStop = false;
            this.grpLogControl.Text = "LogInfo";
            // 
            // btnSearchDay
            // 
            this.btnSearchDay.Location = new System.Drawing.Point(156, 347);
            this.btnSearchDay.Name = "btnSearchDay";
            this.btnSearchDay.Size = new System.Drawing.Size(142, 23);
            this.btnSearchDay.TabIndex = 46;
            this.btnSearchDay.Text = "Search Day";
            this.btnSearchDay.UseVisualStyleBackColor = true;
            this.btnSearchDay.Click += new System.EventHandler(this.btnSearchDay_Click);
            // 
            // btnSearchTrackID
            // 
            this.btnSearchTrackID.Location = new System.Drawing.Point(156, 318);
            this.btnSearchTrackID.Name = "btnSearchTrackID";
            this.btnSearchTrackID.Size = new System.Drawing.Size(142, 23);
            this.btnSearchTrackID.TabIndex = 46;
            this.btnSearchTrackID.Text = "Search Track ID";
            this.btnSearchTrackID.UseVisualStyleBackColor = true;
            this.btnSearchTrackID.Click += new System.EventHandler(this.btnSearchTrackID_Click);
            // 
            // btnSearchCalendar
            // 
            this.btnSearchCalendar.Location = new System.Drawing.Point(156, 289);
            this.btnSearchCalendar.Name = "btnSearchCalendar";
            this.btnSearchCalendar.Size = new System.Drawing.Size(142, 23);
            this.btnSearchCalendar.TabIndex = 46;
            this.btnSearchCalendar.Text = "Search Calendar";
            this.btnSearchCalendar.UseVisualStyleBackColor = true;
            this.btnSearchCalendar.Click += new System.EventHandler(this.btnSearchCalendar_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(51, 115);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 46;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // btnReleaseAuthority
            // 
            this.btnReleaseAuthority.Location = new System.Drawing.Point(156, 81);
            this.btnReleaseAuthority.Name = "btnReleaseAuthority";
            this.btnReleaseAuthority.Size = new System.Drawing.Size(142, 22);
            this.btnReleaseAuthority.TabIndex = 59;
            this.btnReleaseAuthority.Text = "Release Authority";
            this.btnReleaseAuthority.UseVisualStyleBackColor = true;
            this.btnReleaseAuthority.Click += new System.EventHandler(this.btnReleaseAuthority_Click);
            // 
            // btnGetAuthority
            // 
            this.btnGetAuthority.Location = new System.Drawing.Point(8, 81);
            this.btnGetAuthority.Name = "btnGetAuthority";
            this.btnGetAuthority.Size = new System.Drawing.Size(142, 22);
            this.btnGetAuthority.TabIndex = 58;
            this.btnGetAuthority.Text = "Get Authority";
            this.btnGetAuthority.UseVisualStyleBackColor = true;
            this.btnGetAuthority.Click += new System.EventHandler(this.btnGetAuthority_Click);
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(6, 23);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(43, 12);
            this.lblDevice.TabIndex = 57;
            this.lblDevice.Text = "Device";
            // 
            // cbxDevices
            // 
            this.cbxDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDevices.FormattingEnabled = true;
            this.cbxDevices.Location = new System.Drawing.Point(70, 20);
            this.cbxDevices.Name = "cbxDevices";
            this.cbxDevices.Size = new System.Drawing.Size(228, 20);
            this.cbxDevices.TabIndex = 56;
            this.cbxDevices.SelectedIndexChanged += new System.EventHandler(this.cbxDevices_SelectedIndexChanged);
            // 
            // cbxCameras
            // 
            this.cbxCameras.BackColor = System.Drawing.SystemColors.Window;
            this.cbxCameras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCameras.FormattingEnabled = true;
            this.cbxCameras.Location = new System.Drawing.Point(70, 46);
            this.cbxCameras.Name = "cbxCameras";
            this.cbxCameras.Size = new System.Drawing.Size(228, 20);
            this.cbxCameras.TabIndex = 55;
            this.cbxCameras.SelectedIndexChanged += new System.EventHandler(this.cbxCameras_SelectedIndexChanged);
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.Location = new System.Drawing.Point(4, 49);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(50, 12);
            this.lblCamera.TabIndex = 54;
            this.lblCamera.Text = "Camera";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 177);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 12);
            this.lblStatus.TabIndex = 45;
            this.lblStatus.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(12, 202);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStatus.Size = new System.Drawing.Size(334, 193);
            this.txtStatus.TabIndex = 44;
            // 
            // clearLog
            // 
            this.clearLog.Location = new System.Drawing.Point(273, 171);
            this.clearLog.Name = "clearLog";
            this.clearLog.Size = new System.Drawing.Size(73, 25);
            this.clearLog.TabIndex = 47;
            this.clearLog.Text = "Clear";
            this.clearLog.UseVisualStyleBackColor = true;
            this.clearLog.Click += new System.EventHandler(this.clearLog_Click);
            // 
            // txtTrackID
            // 
            this.txtTrackID.Location = new System.Drawing.Point(77, 347);
            this.txtTrackID.Name = "txtTrackID";
            this.txtTrackID.Size = new System.Drawing.Size(63, 21);
            this.txtTrackID.TabIndex = 16;
            this.txtTrackID.Text = "-1";
            // 
            // lblTrackID
            // 
            this.lblTrackID.AutoSize = true;
            this.lblTrackID.Location = new System.Drawing.Point(19, 350);
            this.lblTrackID.Name = "lblTrackID";
            this.lblTrackID.Size = new System.Drawing.Size(52, 12);
            this.lblTrackID.TabIndex = 16;
            this.lblTrackID.Text = "Track ID";
            // 
            // SearchSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 404);
            this.Controls.Add(this.clearLog);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.grpLogControl);
            this.Controls.Add(this.grpLogInInfo);
            this.Name = "SearchSample";
            this.Text = "SearchSample";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchSample_Closing);
            this.Load += new System.EventHandler(this.SearchSample_Load);
            this.grpLogInInfo.ResumeLayout(false);
            this.grpLogInInfo.PerformLayout();
            this.grpLogControl.ResumeLayout(false);
            this.grpLogControl.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpLogControl;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.ComboBox cbxDevices;
        private System.Windows.Forms.ComboBox cbxCameras;
        private System.Windows.Forms.Label lblCamera;
        private System.Windows.Forms.Button btnReleaseAuthority;
        private System.Windows.Forms.Button btnGetAuthority;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button btnSearchCalendar;
        private System.Windows.Forms.Button btnSearchTrackID;
        private System.Windows.Forms.Button btnSearchDay;
        private System.Windows.Forms.Button clearLog;
        private System.Windows.Forms.Label lblTrackID;
        private System.Windows.Forms.TextBox txtTrackID;
    }
}