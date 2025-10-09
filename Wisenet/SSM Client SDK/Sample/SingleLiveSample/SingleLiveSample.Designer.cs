namespace LiveSample
{
    partial class SingleLiveSample
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
            this.btnGetRtspUrl = new System.Windows.Forms.Button();
            this.grpLiveControl = new System.Windows.Forms.GroupBox();
            this.lblCamera = new System.Windows.Forms.Label();
            this.cbxCameras = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtRtspUrl = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.grpAudioControl = new System.Windows.Forms.GroupBox();
            this.btnGetVolume = new System.Windows.Forms.Button();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.btnSetVolume = new System.Windows.Forms.Button();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblSound = new System.Windows.Forms.Label();
            this.btnSetSoundOff = new System.Windows.Forms.Button();
            this.btnSetSoundOn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clearLog = new System.Windows.Forms.Button();
            this.grpLogInInfo.SuspendLayout();
            this.grpLiveControl.SuspendLayout();
            this.grpAudioControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.grpLogInInfo.Location = new System.Drawing.Point(498, 12);
            this.grpLogInInfo.Name = "grpLogInInfo";
            this.grpLogInInfo.Size = new System.Drawing.Size(298, 179);
            this.grpLogInInfo.TabIndex = 8;
            this.grpLogInInfo.TabStop = false;
            this.grpLogInInfo.Text = "LogIn";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(212, 141);
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
            this.btnLogin.Location = new System.Drawing.Point(130, 141);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(76, 23);
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
            // btnGetRtspUrl
            // 
            this.btnGetRtspUrl.Location = new System.Drawing.Point(48, 106);
            this.btnGetRtspUrl.Name = "btnGetRtspUrl";
            this.btnGetRtspUrl.Size = new System.Drawing.Size(76, 23);
            this.btnGetRtspUrl.TabIndex = 14;
            this.btnGetRtspUrl.Text = "Get URL";
            this.btnGetRtspUrl.UseVisualStyleBackColor = true;
            this.btnGetRtspUrl.Click += new System.EventHandler(this.btnGetRtspUrl_Click);
            // 
            // grpLiveControl
            // 
            this.grpLiveControl.Controls.Add(this.btnGetRtspUrl);
            this.grpLiveControl.Controls.Add(this.lblCamera);
            this.grpLiveControl.Controls.Add(this.cbxCameras);
            this.grpLiveControl.Controls.Add(this.btnClose);
            this.grpLiveControl.Controls.Add(this.btnOpen);
            this.grpLiveControl.Controls.Add(this.lblURL);
            this.grpLiveControl.Controls.Add(this.txtRtspUrl);
            this.grpLiveControl.Location = new System.Drawing.Point(498, 197);
            this.grpLiveControl.Name = "grpLiveControl";
            this.grpLiveControl.Size = new System.Drawing.Size(298, 137);
            this.grpLiveControl.TabIndex = 30;
            this.grpLiveControl.TabStop = false;
            this.grpLiveControl.Text = "Live Control";
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.Location = new System.Drawing.Point(6, 27);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(50, 12);
            this.lblCamera.TabIndex = 32;
            this.lblCamera.Text = "Camera";
            // 
            // cbxCameras
            // 
            this.cbxCameras.BackColor = System.Drawing.SystemColors.Window;
            this.cbxCameras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCameras.FormattingEnabled = true;
            this.cbxCameras.Location = new System.Drawing.Point(80, 24);
            this.cbxCameras.Name = "cbxCameras";
            this.cbxCameras.Size = new System.Drawing.Size(208, 20);
            this.cbxCameras.TabIndex = 31;
            this.cbxCameras.SelectedIndexChanged += new System.EventHandler(this.cbxCameras_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(212, 106);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(130, 106);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(76, 23);
            this.btnOpen.TabIndex = 12;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(6, 53);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(28, 12);
            this.lblURL.TabIndex = 7;
            this.lblURL.Text = "URL";
            // 
            // txtRtspUrl
            // 
            this.txtRtspUrl.Location = new System.Drawing.Point(80, 50);
            this.txtRtspUrl.Name = "txtRtspUrl";
            this.txtRtspUrl.Size = new System.Drawing.Size(208, 21);
            this.txtRtspUrl.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(10, 336);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 12);
            this.lblStatus.TabIndex = 34;
            this.lblStatus.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(12, 361);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStatus.Size = new System.Drawing.Size(480, 144);
            this.txtStatus.TabIndex = 33;
            // 
            // grpAudioControl
            // 
            this.grpAudioControl.Controls.Add(this.btnGetVolume);
            this.grpAudioControl.Controls.Add(this.txtVolume);
            this.grpAudioControl.Controls.Add(this.btnSetVolume);
            this.grpAudioControl.Controls.Add(this.lblVolume);
            this.grpAudioControl.Controls.Add(this.lblSound);
            this.grpAudioControl.Controls.Add(this.btnSetSoundOff);
            this.grpAudioControl.Controls.Add(this.btnSetSoundOn);
            this.grpAudioControl.Location = new System.Drawing.Point(499, 346);
            this.grpAudioControl.Name = "grpAudioControl";
            this.grpAudioControl.Size = new System.Drawing.Size(297, 100);
            this.grpAudioControl.TabIndex = 37;
            this.grpAudioControl.TabStop = false;
            this.grpAudioControl.Text = "Audio Control";
            // 
            // btnGetVolume
            // 
            this.btnGetVolume.Location = new System.Drawing.Point(120, 77);
            this.btnGetVolume.Name = "btnGetVolume";
            this.btnGetVolume.Size = new System.Drawing.Size(45, 23);
            this.btnGetVolume.TabIndex = 41;
            this.btnGetVolume.Text = "Get";
            this.btnGetVolume.UseVisualStyleBackColor = true;
            this.btnGetVolume.Click += new System.EventHandler(this.btnGetVolume_Click);
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(69, 51);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(45, 21);
            this.txtVolume.TabIndex = 40;
            this.txtVolume.Text = "50";
            // 
            // btnSetVolume
            // 
            this.btnSetVolume.Location = new System.Drawing.Point(120, 49);
            this.btnSetVolume.Name = "btnSetVolume";
            this.btnSetVolume.Size = new System.Drawing.Size(45, 23);
            this.btnSetVolume.TabIndex = 39;
            this.btnSetVolume.Text = "Set";
            this.btnSetVolume.UseVisualStyleBackColor = true;
            this.btnSetVolume.Click += new System.EventHandler(this.btnSetVolume_Click);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(17, 54);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(48, 12);
            this.lblVolume.TabIndex = 38;
            this.lblVolume.Text = "Volume";
            // 
            // lblSound
            // 
            this.lblSound.AutoSize = true;
            this.lblSound.Location = new System.Drawing.Point(17, 27);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(41, 12);
            this.lblSound.TabIndex = 2;
            this.lblSound.Text = "Sound";
            // 
            // btnSetSoundOff
            // 
            this.btnSetSoundOff.Location = new System.Drawing.Point(120, 20);
            this.btnSetSoundOff.Name = "btnSetSoundOff";
            this.btnSetSoundOff.Size = new System.Drawing.Size(45, 23);
            this.btnSetSoundOff.TabIndex = 1;
            this.btnSetSoundOff.Text = "Off";
            this.btnSetSoundOff.UseVisualStyleBackColor = true;
            this.btnSetSoundOff.Click += new System.EventHandler(this.btnSetSoundOff_Click);
            // 
            // btnSetSoundOn
            // 
            this.btnSetSoundOn.Location = new System.Drawing.Point(69, 20);
            this.btnSetSoundOn.Name = "btnSetSoundOn";
            this.btnSetSoundOn.Size = new System.Drawing.Size(45, 23);
            this.btnSetSoundOn.TabIndex = 0;
            this.btnSetSoundOn.Text = "On";
            this.btnSetSoundOn.UseVisualStyleBackColor = true;
            this.btnSetSoundOn.Click += new System.EventHandler(this.btnSetSoundOn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 312);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // clearLog
            // 
            this.clearLog.Location = new System.Drawing.Point(419, 330);
            this.clearLog.Name = "clearLog";
            this.clearLog.Size = new System.Drawing.Size(73, 25);
            this.clearLog.TabIndex = 47;
            this.clearLog.Text = "Clear";
            this.clearLog.UseVisualStyleBackColor = true;
            this.clearLog.Click += new System.EventHandler(this.clearLog_Click);
            // 
            // SingleLiveSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 517);
            this.Controls.Add(this.clearLog);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpAudioControl);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.grpLiveControl);
            this.Controls.Add(this.grpLogInInfo);
            this.Name = "SingleLiveSample";
            this.Text = "Live Sample";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LiveSample_Closing);
            this.Load += new System.EventHandler(this.LiveSample_Load);
            this.grpLogInInfo.ResumeLayout(false);
            this.grpLogInInfo.PerformLayout();
            this.grpLiveControl.ResumeLayout(false);
            this.grpLiveControl.PerformLayout();
            this.grpAudioControl.ResumeLayout(false);
            this.grpAudioControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLogInInfo;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox grpLiveControl;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtRtspUrl;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnGetRtspUrl;
        private System.Windows.Forms.ComboBox cbxCameras;
        private System.Windows.Forms.Label lblCamera;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.GroupBox grpAudioControl;
        private System.Windows.Forms.Button btnSetSoundOn;
        private System.Windows.Forms.Label lblSound;
        private System.Windows.Forms.Button btnSetSoundOff;
        private System.Windows.Forms.Button btnSetVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Button btnGetVolume;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button clearLog;
    }
}