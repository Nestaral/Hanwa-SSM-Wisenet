namespace PlaybackSample
{
    partial class PlaybackSample
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.grpPlaybackControl = new System.Windows.Forms.GroupBox();
            this.btnSaveSnapshot = new System.Windows.Forms.Button();
            this.btnGetNextFrame = new System.Windows.Forms.Button();
            this.btnGetPrevFrame = new System.Windows.Forms.Button();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblSeekTime = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.txtSeekTime = new System.Windows.Forms.TextBox();
            this.btnSeek = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.btnGetTimeZone = new System.Windows.Forms.Button();
            this.lblDevice = new System.Windows.Forms.Label();
            this.btnGetRtspUrl = new System.Windows.Forms.Button();
            this.lblCamera = new System.Windows.Forms.Label();
            this.cbxDevices = new System.Windows.Forms.ComboBox();
            this.cbxCameras = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtRtspUrl = new System.Windows.Forms.TextBox();
            this.grpLoginInfo = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPW = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clearLog = new System.Windows.Forms.Button();
            this.grpPlaybackControl.SuspendLayout();
            this.grpLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 325);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 12);
            this.lblStatus.TabIndex = 36;
            this.lblStatus.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(14, 350);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStatus.Size = new System.Drawing.Size(480, 144);
            this.txtStatus.TabIndex = 35;
            // 
            // grpPlaybackControl
            // 
            this.grpPlaybackControl.Controls.Add(this.btnSaveSnapshot);
            this.grpPlaybackControl.Controls.Add(this.btnGetNextFrame);
            this.grpPlaybackControl.Controls.Add(this.btnGetPrevFrame);
            this.grpPlaybackControl.Controls.Add(this.lblSpeed);
            this.grpPlaybackControl.Controls.Add(this.lblSeekTime);
            this.grpPlaybackControl.Controls.Add(this.txtSpeed);
            this.grpPlaybackControl.Controls.Add(this.txtSeekTime);
            this.grpPlaybackControl.Controls.Add(this.btnSeek);
            this.grpPlaybackControl.Controls.Add(this.btnPlay);
            this.grpPlaybackControl.Controls.Add(this.btnPause);
            this.grpPlaybackControl.Controls.Add(this.lblStartTime);
            this.grpPlaybackControl.Controls.Add(this.txtStartTime);
            this.grpPlaybackControl.Controls.Add(this.btnGetTimeZone);
            this.grpPlaybackControl.Controls.Add(this.lblDevice);
            this.grpPlaybackControl.Controls.Add(this.btnGetRtspUrl);
            this.grpPlaybackControl.Controls.Add(this.lblCamera);
            this.grpPlaybackControl.Controls.Add(this.cbxDevices);
            this.grpPlaybackControl.Controls.Add(this.cbxCameras);
            this.grpPlaybackControl.Controls.Add(this.btnClose);
            this.grpPlaybackControl.Controls.Add(this.btnOpen);
            this.grpPlaybackControl.Controls.Add(this.lblUrl);
            this.grpPlaybackControl.Controls.Add(this.txtRtspUrl);
            this.grpPlaybackControl.Location = new System.Drawing.Point(498, 179);
            this.grpPlaybackControl.Name = "grpPlaybackControl";
            this.grpPlaybackControl.Size = new System.Drawing.Size(298, 315);
            this.grpPlaybackControl.TabIndex = 38;
            this.grpPlaybackControl.TabStop = false;
            this.grpPlaybackControl.Text = "Playback Control";
            // 
            // btnSaveSnapshot
            // 
            this.btnSaveSnapshot.Location = new System.Drawing.Point(196, 269);
            this.btnSaveSnapshot.Name = "btnSaveSnapshot";
            this.btnSaveSnapshot.Size = new System.Drawing.Size(75, 40);
            this.btnSaveSnapshot.TabIndex = 73;
            this.btnSaveSnapshot.Text = "Snapshot";
            this.btnSaveSnapshot.UseVisualStyleBackColor = true;
            this.btnSaveSnapshot.Click += new System.EventHandler(this.btnSaveSnapshot_Click);
            // 
            // btnGetNextFrame
            // 
            this.btnGetNextFrame.Location = new System.Drawing.Point(115, 269);
            this.btnGetNextFrame.Name = "btnGetNextFrame";
            this.btnGetNextFrame.Size = new System.Drawing.Size(75, 40);
            this.btnGetNextFrame.TabIndex = 72;
            this.btnGetNextFrame.Text = "Next Frame";
            this.btnGetNextFrame.UseVisualStyleBackColor = true;
            this.btnGetNextFrame.Click += new System.EventHandler(this.btnGetNextFrame_Click);
            // 
            // btnGetPrevFrame
            // 
            this.btnGetPrevFrame.Location = new System.Drawing.Point(34, 269);
            this.btnGetPrevFrame.Name = "btnGetPrevFrame";
            this.btnGetPrevFrame.Size = new System.Drawing.Size(75, 40);
            this.btnGetPrevFrame.TabIndex = 71;
            this.btnGetPrevFrame.Text = "Prev Frame";
            this.btnGetPrevFrame.UseVisualStyleBackColor = true;
            this.btnGetPrevFrame.Click += new System.EventHandler(this.btnGetPrevFrame_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(6, 208);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(41, 12);
            this.lblSpeed.TabIndex = 70;
            this.lblSpeed.Text = "Speed";
            // 
            // lblSeekTime
            // 
            this.lblSeekTime.AutoSize = true;
            this.lblSeekTime.Location = new System.Drawing.Point(6, 236);
            this.lblSeekTime.Name = "lblSeekTime";
            this.lblSeekTime.Size = new System.Drawing.Size(66, 12);
            this.lblSeekTime.TabIndex = 69;
            this.lblSeekTime.Text = "Seek Time";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(80, 205);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(55, 21);
            this.txtSpeed.TabIndex = 68;
            this.txtSpeed.Text = "1.0";
            // 
            // txtSeekTime
            // 
            this.txtSeekTime.Location = new System.Drawing.Point(80, 231);
            this.txtSeekTime.Name = "txtSeekTime";
            this.txtSeekTime.Size = new System.Drawing.Size(110, 21);
            this.txtSeekTime.TabIndex = 67;
            this.txtSeekTime.Text = "20200323T111000";
            // 
            // btnSeek
            // 
            this.btnSeek.Location = new System.Drawing.Point(196, 231);
            this.btnSeek.Name = "btnSeek";
            this.btnSeek.Size = new System.Drawing.Size(88, 21);
            this.btnSeek.TabIndex = 66;
            this.btnSeek.Text = "Seek";
            this.btnSeek.UseVisualStyleBackColor = true;
            this.btnSeek.Click += new System.EventHandler(this.btnSeek_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(148, 204);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(65, 21);
            this.btnPlay.TabIndex = 65;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(219, 204);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(65, 21);
            this.btnPause.TabIndex = 40;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(6, 150);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(63, 12);
            this.lblStartTime.TabIndex = 63;
            this.lblStartTime.Text = "Start Time";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(80, 147);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(110, 21);
            this.txtStartTime.TabIndex = 62;
            this.txtStartTime.Text = "20200323T110000";
            // 
            // btnGetTimeZone
            // 
            this.btnGetTimeZone.Location = new System.Drawing.Point(161, 106);
            this.btnGetTimeZone.Name = "btnGetTimeZone";
            this.btnGetTimeZone.Size = new System.Drawing.Size(127, 23);
            this.btnGetTimeZone.TabIndex = 39;
            this.btnGetTimeZone.Text = "Get TimeZone";
            this.btnGetTimeZone.UseVisualStyleBackColor = true;
            this.btnGetTimeZone.Click += new System.EventHandler(this.btnGetTimeZone_Click);
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(6, 25);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(43, 12);
            this.lblDevice.TabIndex = 61;
            this.lblDevice.Text = "Device";
            // 
            // btnGetRtspUrl
            // 
            this.btnGetRtspUrl.Location = new System.Drawing.Point(8, 106);
            this.btnGetRtspUrl.Name = "btnGetRtspUrl";
            this.btnGetRtspUrl.Size = new System.Drawing.Size(127, 23);
            this.btnGetRtspUrl.TabIndex = 14;
            this.btnGetRtspUrl.Text = "Get URL";
            this.btnGetRtspUrl.UseVisualStyleBackColor = true;
            this.btnGetRtspUrl.Click += new System.EventHandler(this.btnGetRtspUrl_Click);
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.Location = new System.Drawing.Point(6, 51);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(50, 12);
            this.lblCamera.TabIndex = 32;
            this.lblCamera.Text = "Camera";
            // 
            // cbxDevices
            // 
            this.cbxDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDevices.FormattingEnabled = true;
            this.cbxDevices.Location = new System.Drawing.Point(80, 22);
            this.cbxDevices.Name = "cbxDevices";
            this.cbxDevices.Size = new System.Drawing.Size(208, 20);
            this.cbxDevices.TabIndex = 60;
            this.cbxDevices.SelectedIndexChanged += new System.EventHandler(this.cbxDevices_SelectedIndexChanged);
            // 
            // cbxCameras
            // 
            this.cbxCameras.BackColor = System.Drawing.SystemColors.Window;
            this.cbxCameras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCameras.FormattingEnabled = true;
            this.cbxCameras.Location = new System.Drawing.Point(80, 48);
            this.cbxCameras.Name = "cbxCameras";
            this.cbxCameras.Size = new System.Drawing.Size(208, 20);
            this.cbxCameras.TabIndex = 31;
            this.cbxCameras.SelectedIndexChanged += new System.EventHandler(this.cbxCameras_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(161, 170);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 25);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(8, 171);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(127, 24);
            this.btnOpen.TabIndex = 12;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(6, 77);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(28, 12);
            this.lblUrl.TabIndex = 7;
            this.lblUrl.Text = "URL";
            // 
            // txtRtspUrl
            // 
            this.txtRtspUrl.Location = new System.Drawing.Point(80, 74);
            this.txtRtspUrl.Name = "txtRtspUrl";
            this.txtRtspUrl.Size = new System.Drawing.Size(208, 21);
            this.txtRtspUrl.TabIndex = 3;
            // 
            // grpLoginInfo
            // 
            this.grpLoginInfo.Controls.Add(this.btnLogout);
            this.grpLoginInfo.Controls.Add(this.lblPort);
            this.grpLoginInfo.Controls.Add(this.lblIPAddress);
            this.grpLoginInfo.Controls.Add(this.btnLogin);
            this.grpLoginInfo.Controls.Add(this.lblPW);
            this.grpLoginInfo.Controls.Add(this.txtPort);
            this.grpLoginInfo.Controls.Add(this.txtIPAddress);
            this.grpLoginInfo.Controls.Add(this.txtPassword);
            this.grpLoginInfo.Controls.Add(this.txtID);
            this.grpLoginInfo.Controls.Add(this.lblID);
            this.grpLoginInfo.Location = new System.Drawing.Point(498, 12);
            this.grpLoginInfo.Name = "grpLoginInfo";
            this.grpLoginInfo.Size = new System.Drawing.Size(298, 161);
            this.grpLoginInfo.TabIndex = 37;
            this.grpLoginInfo.TabStop = false;
            this.grpLoginInfo.Text = "Login";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(212, 130);
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
            this.btnLogin.Location = new System.Drawing.Point(130, 130);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(76, 23);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Location = new System.Drawing.Point(6, 51);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(62, 12);
            this.lblPW.TabIndex = 11;
            this.lblPW.Text = "Password";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(103, 103);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(185, 21);
            this.txtPort.TabIndex = 10;
            this.txtPort.Text = "9999";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(103, 76);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(185, 21);
            this.txtIPAddress.TabIndex = 9;
            this.txtIPAddress.Text = "127.0.0.1";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(103, 48);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(185, 21);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "init123!!";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(103, 20);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(185, 21);
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // clearLog
            // 
            this.clearLog.Location = new System.Drawing.Point(419, 319);
            this.clearLog.Name = "clearLog";
            this.clearLog.Size = new System.Drawing.Size(73, 25);
            this.clearLog.TabIndex = 65;
            this.clearLog.Text = "Clear";
            this.clearLog.UseVisualStyleBackColor = true;
            this.clearLog.Click += new System.EventHandler(this.clearLog_Click);
            // 
            // PlaybackSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 509);
            this.Controls.Add(this.clearLog);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpPlaybackControl);
            this.Controls.Add(this.grpLoginInfo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtStatus);
            this.Name = "PlaybackSample";
            this.Text = "Playback Sample";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlaybackSample_Closing);
            this.Load += new System.EventHandler(this.PlaybackSample_Load);
            this.grpPlaybackControl.ResumeLayout(false);
            this.grpPlaybackControl.PerformLayout();
            this.grpLoginInfo.ResumeLayout(false);
            this.grpLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.GroupBox grpPlaybackControl;
        private System.Windows.Forms.Button btnGetRtspUrl;
        private System.Windows.Forms.Label lblCamera;
        private System.Windows.Forms.ComboBox cbxCameras;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtRtspUrl;
        private System.Windows.Forms.GroupBox grpLoginInfo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.ComboBox cbxDevices;
        private System.Windows.Forms.Button btnGetTimeZone;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblSeekTime;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.TextBox txtSeekTime;
        private System.Windows.Forms.Button btnSeek;
        private System.Windows.Forms.Button btnGetPrevFrame;
        private System.Windows.Forms.Button btnGetNextFrame;
        private System.Windows.Forms.Button btnSaveSnapshot;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button clearLog;
    }
}