namespace PTZSample
{
    partial class PTZSample
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
            this.groupPTZControl = new System.Windows.Forms.GroupBox();
            this.btnRunPreset = new System.Windows.Forms.Button();
            this.groupPTZ = new System.Windows.Forms.GroupBox();
            this.lblPtzSpeed = new System.Windows.Forms.Label();
            this.txtPTZSpeed = new System.Windows.Forms.TextBox();
            this.trackBarPTZSpeed = new System.Windows.Forms.TrackBar();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnPTZDownRight = new System.Windows.Forms.Button();
            this.btnPTZDown = new System.Windows.Forms.Button();
            this.btnPTZDownLeft = new System.Windows.Forms.Button();
            this.btnPTZRight = new System.Windows.Forms.Button();
            this.btnPTZStop = new System.Windows.Forms.Button();
            this.btnPTZLeft = new System.Windows.Forms.Button();
            this.btnPTZUpRight = new System.Windows.Forms.Button();
            this.btnPTZUp = new System.Windows.Forms.Button();
            this.btnPTZUpLeft = new System.Windows.Forms.Button();
            this.lblPresetName = new System.Windows.Forms.Label();
            this.lblPresetIndex = new System.Windows.Forms.Label();
            this.txtPresetName = new System.Windows.Forms.TextBox();
            this.txtPresetIndex = new System.Windows.Forms.TextBox();
            this.btnAddPreset = new System.Windows.Forms.Button();
            this.btnGetPresetList = new System.Windows.Forms.Button();
            this.grpMediaControl = new System.Windows.Forms.GroupBox();
            this.btnGetRtspUrl = new System.Windows.Forms.Button();
            this.lblCamera = new System.Windows.Forms.Label();
            this.cbxCameras = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtRtspUrl = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPW = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clearLog = new System.Windows.Forms.Button();
            this.groupPTZControl.SuspendLayout();
            this.groupPTZ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPTZSpeed)).BeginInit();
            this.grpMediaControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPTZControl
            // 
            this.groupPTZControl.Controls.Add(this.btnRunPreset);
            this.groupPTZControl.Controls.Add(this.groupPTZ);
            this.groupPTZControl.Controls.Add(this.lblPresetName);
            this.groupPTZControl.Controls.Add(this.lblPresetIndex);
            this.groupPTZControl.Controls.Add(this.txtPresetName);
            this.groupPTZControl.Controls.Add(this.txtPresetIndex);
            this.groupPTZControl.Controls.Add(this.btnAddPreset);
            this.groupPTZControl.Controls.Add(this.btnGetPresetList);
            this.groupPTZControl.Location = new System.Drawing.Point(499, 338);
            this.groupPTZControl.Name = "groupPTZControl";
            this.groupPTZControl.Size = new System.Drawing.Size(298, 233);
            this.groupPTZControl.TabIndex = 38;
            this.groupPTZControl.TabStop = false;
            this.groupPTZControl.Text = "PTZ Control";
            // 
            // btnRunPreset
            // 
            this.btnRunPreset.Location = new System.Drawing.Point(212, 175);
            this.btnRunPreset.Name = "btnRunPreset";
            this.btnRunPreset.Size = new System.Drawing.Size(80, 25);
            this.btnRunPreset.TabIndex = 31;
            this.btnRunPreset.Text = "Run Preset";
            this.btnRunPreset.UseVisualStyleBackColor = true;
            this.btnRunPreset.Click += new System.EventHandler(this.btnRunPreset_Click);
            // 
            // groupPTZ
            // 
            this.groupPTZ.Controls.Add(this.lblPtzSpeed);
            this.groupPTZ.Controls.Add(this.txtPTZSpeed);
            this.groupPTZ.Controls.Add(this.trackBarPTZSpeed);
            this.groupPTZ.Controls.Add(this.btnZoomOut);
            this.groupPTZ.Controls.Add(this.btnZoomIn);
            this.groupPTZ.Controls.Add(this.btnPTZDownRight);
            this.groupPTZ.Controls.Add(this.btnPTZDown);
            this.groupPTZ.Controls.Add(this.btnPTZDownLeft);
            this.groupPTZ.Controls.Add(this.btnPTZRight);
            this.groupPTZ.Controls.Add(this.btnPTZStop);
            this.groupPTZ.Controls.Add(this.btnPTZLeft);
            this.groupPTZ.Controls.Add(this.btnPTZUpRight);
            this.groupPTZ.Controls.Add(this.btnPTZUp);
            this.groupPTZ.Controls.Add(this.btnPTZUpLeft);
            this.groupPTZ.Location = new System.Drawing.Point(8, 22);
            this.groupPTZ.Name = "groupPTZ";
            this.groupPTZ.Size = new System.Drawing.Size(196, 205);
            this.groupPTZ.TabIndex = 29;
            this.groupPTZ.TabStop = false;
            this.groupPTZ.Text = "Pan Tilt Zoom";
            // 
            // lblPtzSpeed
            // 
            this.lblPtzSpeed.AutoSize = true;
            this.lblPtzSpeed.Location = new System.Drawing.Point(144, 15);
            this.lblPtzSpeed.Name = "lblPtzSpeed";
            this.lblPtzSpeed.Size = new System.Drawing.Size(41, 12);
            this.lblPtzSpeed.TabIndex = 49;
            this.lblPtzSpeed.Text = "Speed";
            // 
            // txtPTZSpeed
            // 
            this.txtPTZSpeed.Location = new System.Drawing.Point(140, 172);
            this.txtPTZSpeed.Name = "txtPTZSpeed";
            this.txtPTZSpeed.Size = new System.Drawing.Size(45, 21);
            this.txtPTZSpeed.TabIndex = 41;
            this.txtPTZSpeed.TextChanged += new System.EventHandler(this.txtPTZSpeed_TextChanged);
            // 
            // trackBarPTZSpeed
            // 
            this.trackBarPTZSpeed.Location = new System.Drawing.Point(140, 20);
            this.trackBarPTZSpeed.Maximum = 100;
            this.trackBarPTZSpeed.Name = "trackBarPTZSpeed";
            this.trackBarPTZSpeed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarPTZSpeed.Size = new System.Drawing.Size(45, 146);
            this.trackBarPTZSpeed.TabIndex = 40;
            this.trackBarPTZSpeed.Scroll += new System.EventHandler(this.trackBarPTZSpeed_Scroll);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Location = new System.Drawing.Point(72, 158);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(43, 35);
            this.btnZoomOut.TabIndex = 39;
            this.btnZoomOut.Text = "-";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Location = new System.Drawing.Point(23, 158);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(43, 35);
            this.btnZoomIn.TabIndex = 38;
            this.btnZoomIn.Text = "+";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnPTZDownRight
            // 
            this.btnPTZDownRight.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPTZDownRight.Location = new System.Drawing.Point(98, 112);
            this.btnPTZDownRight.Name = "btnPTZDownRight";
            this.btnPTZDownRight.Size = new System.Drawing.Size(40, 40);
            this.btnPTZDownRight.TabIndex = 37;
            this.btnPTZDownRight.Text = "↘";
            this.btnPTZDownRight.UseVisualStyleBackColor = true;
            this.btnPTZDownRight.Click += new System.EventHandler(this.btnPTZDownRight_Click);
            // 
            // btnPTZDown
            // 
            this.btnPTZDown.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPTZDown.Location = new System.Drawing.Point(52, 112);
            this.btnPTZDown.Name = "btnPTZDown";
            this.btnPTZDown.Size = new System.Drawing.Size(40, 40);
            this.btnPTZDown.TabIndex = 36;
            this.btnPTZDown.Text = "↓";
            this.btnPTZDown.UseVisualStyleBackColor = true;
            this.btnPTZDown.Click += new System.EventHandler(this.btnPTZDown_Click);
            // 
            // btnPTZDownLeft
            // 
            this.btnPTZDownLeft.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPTZDownLeft.Location = new System.Drawing.Point(6, 112);
            this.btnPTZDownLeft.Name = "btnPTZDownLeft";
            this.btnPTZDownLeft.Size = new System.Drawing.Size(40, 40);
            this.btnPTZDownLeft.TabIndex = 35;
            this.btnPTZDownLeft.Text = "↙";
            this.btnPTZDownLeft.UseVisualStyleBackColor = true;
            this.btnPTZDownLeft.Click += new System.EventHandler(this.btnPTZDownLeft_Click);
            // 
            // btnPTZRight
            // 
            this.btnPTZRight.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPTZRight.Location = new System.Drawing.Point(98, 66);
            this.btnPTZRight.Name = "btnPTZRight";
            this.btnPTZRight.Size = new System.Drawing.Size(40, 40);
            this.btnPTZRight.TabIndex = 34;
            this.btnPTZRight.Text = "→";
            this.btnPTZRight.UseVisualStyleBackColor = true;
            this.btnPTZRight.Click += new System.EventHandler(this.btnPTZRight_Click);
            // 
            // btnPTZStop
            // 
            this.btnPTZStop.Location = new System.Drawing.Point(52, 66);
            this.btnPTZStop.Name = "btnPTZStop";
            this.btnPTZStop.Size = new System.Drawing.Size(40, 40);
            this.btnPTZStop.TabIndex = 33;
            this.btnPTZStop.Text = "□";
            this.btnPTZStop.UseVisualStyleBackColor = true;
            this.btnPTZStop.Click += new System.EventHandler(this.btnPTZStop_Click);
            // 
            // btnPTZLeft
            // 
            this.btnPTZLeft.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPTZLeft.Location = new System.Drawing.Point(6, 66);
            this.btnPTZLeft.Name = "btnPTZLeft";
            this.btnPTZLeft.Size = new System.Drawing.Size(40, 40);
            this.btnPTZLeft.TabIndex = 32;
            this.btnPTZLeft.Text = "←";
            this.btnPTZLeft.UseVisualStyleBackColor = true;
            this.btnPTZLeft.Click += new System.EventHandler(this.btnPTZLeft_Click);
            // 
            // btnPTZUpRight
            // 
            this.btnPTZUpRight.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPTZUpRight.Location = new System.Drawing.Point(98, 20);
            this.btnPTZUpRight.Name = "btnPTZUpRight";
            this.btnPTZUpRight.Size = new System.Drawing.Size(40, 40);
            this.btnPTZUpRight.TabIndex = 31;
            this.btnPTZUpRight.Text = "↗";
            this.btnPTZUpRight.UseVisualStyleBackColor = true;
            this.btnPTZUpRight.Click += new System.EventHandler(this.btnPTZUpRight_Click);
            // 
            // btnPTZUp
            // 
            this.btnPTZUp.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPTZUp.Location = new System.Drawing.Point(52, 20);
            this.btnPTZUp.Name = "btnPTZUp";
            this.btnPTZUp.Size = new System.Drawing.Size(40, 40);
            this.btnPTZUp.TabIndex = 30;
            this.btnPTZUp.Text = "↑";
            this.btnPTZUp.UseVisualStyleBackColor = true;
            this.btnPTZUp.Click += new System.EventHandler(this.btnPTZUp_Click);
            // 
            // btnPTZUpLeft
            // 
            this.btnPTZUpLeft.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPTZUpLeft.Location = new System.Drawing.Point(6, 20);
            this.btnPTZUpLeft.Name = "btnPTZUpLeft";
            this.btnPTZUpLeft.Size = new System.Drawing.Size(40, 40);
            this.btnPTZUpLeft.TabIndex = 29;
            this.btnPTZUpLeft.Text = "↖";
            this.btnPTZUpLeft.UseVisualStyleBackColor = true;
            this.btnPTZUpLeft.Click += new System.EventHandler(this.btnPTZUpLeft_Click);
            // 
            // lblPresetName
            // 
            this.lblPresetName.AutoSize = true;
            this.lblPresetName.Location = new System.Drawing.Point(210, 68);
            this.lblPresetName.Name = "lblPresetName";
            this.lblPresetName.Size = new System.Drawing.Size(39, 12);
            this.lblPresetName.TabIndex = 30;
            this.lblPresetName.Text = "Name";
            // 
            // lblPresetIndex
            // 
            this.lblPresetIndex.AutoSize = true;
            this.lblPresetIndex.Location = new System.Drawing.Point(210, 22);
            this.lblPresetIndex.Name = "lblPresetIndex";
            this.lblPresetIndex.Size = new System.Drawing.Size(36, 12);
            this.lblPresetIndex.TabIndex = 29;
            this.lblPresetIndex.Text = "Index";
            // 
            // txtPresetName
            // 
            this.txtPresetName.Location = new System.Drawing.Point(212, 83);
            this.txtPresetName.Name = "txtPresetName";
            this.txtPresetName.Size = new System.Drawing.Size(80, 21);
            this.txtPresetName.TabIndex = 28;
            // 
            // txtPresetIndex
            // 
            this.txtPresetIndex.Location = new System.Drawing.Point(212, 37);
            this.txtPresetIndex.Name = "txtPresetIndex";
            this.txtPresetIndex.Size = new System.Drawing.Size(62, 21);
            this.txtPresetIndex.TabIndex = 27;
            // 
            // btnAddPreset
            // 
            this.btnAddPreset.Location = new System.Drawing.Point(212, 114);
            this.btnAddPreset.Name = "btnAddPreset";
            this.btnAddPreset.Size = new System.Drawing.Size(80, 25);
            this.btnAddPreset.TabIndex = 2;
            this.btnAddPreset.Text = "Add Preset";
            this.btnAddPreset.UseVisualStyleBackColor = true;
            this.btnAddPreset.Click += new System.EventHandler(this.btnAddPreset_Click);
            // 
            // btnGetPresetList
            // 
            this.btnGetPresetList.Location = new System.Drawing.Point(212, 145);
            this.btnGetPresetList.Name = "btnGetPresetList";
            this.btnGetPresetList.Size = new System.Drawing.Size(80, 24);
            this.btnGetPresetList.TabIndex = 1;
            this.btnGetPresetList.Text = "Get Preset List";
            this.btnGetPresetList.UseVisualStyleBackColor = true;
            this.btnGetPresetList.Click += new System.EventHandler(this.btnGetPresetList_Click);
            // 
            // grpMediaControl
            // 
            this.grpMediaControl.Controls.Add(this.btnGetRtspUrl);
            this.grpMediaControl.Controls.Add(this.lblCamera);
            this.grpMediaControl.Controls.Add(this.cbxCameras);
            this.grpMediaControl.Controls.Add(this.btnClose);
            this.grpMediaControl.Controls.Add(this.btnOpen);
            this.grpMediaControl.Controls.Add(this.lblUrl);
            this.grpMediaControl.Controls.Add(this.txtRtspUrl);
            this.grpMediaControl.Location = new System.Drawing.Point(499, 197);
            this.grpMediaControl.Name = "grpMediaControl";
            this.grpMediaControl.Size = new System.Drawing.Size(298, 135);
            this.grpMediaControl.TabIndex = 41;
            this.grpMediaControl.TabStop = false;
            this.grpMediaControl.Text = "Media Control";
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
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(6, 53);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(28, 12);
            this.lblUrl.TabIndex = 7;
            this.lblUrl.Text = "URL";
            // 
            // txtRtspUrl
            // 
            this.txtRtspUrl.Location = new System.Drawing.Point(80, 50);
            this.txtRtspUrl.Name = "txtRtspUrl";
            this.txtRtspUrl.Size = new System.Drawing.Size(208, 21);
            this.txtRtspUrl.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLogout);
            this.groupBox1.Controls.Add(this.lblPort);
            this.groupBox1.Controls.Add(this.lblIP);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.lblPW);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.txtIPAddress);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Location = new System.Drawing.Point(499, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 179);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
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
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(6, 79);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(79, 12);
            this.lblIP.TabIndex = 12;
            this.lblIP.Text = "SM Server IP";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(130, 141);
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
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(10, 335);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 12);
            this.lblStatus.TabIndex = 47;
            this.lblStatus.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(12, 360);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStatus.Size = new System.Drawing.Size(481, 211);
            this.txtStatus.TabIndex = 48;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // clearLog
            // 
            this.clearLog.Location = new System.Drawing.Point(420, 329);
            this.clearLog.Name = "clearLog";
            this.clearLog.Size = new System.Drawing.Size(73, 25);
            this.clearLog.TabIndex = 66;
            this.clearLog.Text = "Clear";
            this.clearLog.UseVisualStyleBackColor = true;
            this.clearLog.Click += new System.EventHandler(this.clearLog_Click);
            // 
            // PTZSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 587);
            this.Controls.Add(this.clearLog);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpMediaControl);
            this.Controls.Add(this.groupPTZControl);
            this.Name = "PTZSample";
            this.Text = "PTZ Sample";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PTZSample_Closing);
            this.Load += new System.EventHandler(this.PTZSample_Load);
            this.groupPTZControl.ResumeLayout(false);
            this.groupPTZControl.PerformLayout();
            this.groupPTZ.ResumeLayout(false);
            this.groupPTZ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPTZSpeed)).EndInit();
            this.grpMediaControl.ResumeLayout(false);
            this.grpMediaControl.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupPTZControl;
        private System.Windows.Forms.Button btnRunPreset;
        private System.Windows.Forms.GroupBox groupPTZ;
        private System.Windows.Forms.TextBox txtPTZSpeed;
        private System.Windows.Forms.TrackBar trackBarPTZSpeed;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnPTZDownRight;
        private System.Windows.Forms.Button btnPTZDown;
        private System.Windows.Forms.Button btnPTZDownLeft;
        private System.Windows.Forms.Button btnPTZRight;
        private System.Windows.Forms.Button btnPTZStop;
        private System.Windows.Forms.Button btnPTZLeft;
        private System.Windows.Forms.Button btnPTZUpRight;
        private System.Windows.Forms.Button btnPTZUp;
        private System.Windows.Forms.Button btnPTZUpLeft;
        private System.Windows.Forms.Label lblPresetName;
        private System.Windows.Forms.Label lblPresetIndex;
        private System.Windows.Forms.TextBox txtPresetName;
        private System.Windows.Forms.TextBox txtPresetIndex;
        private System.Windows.Forms.Button btnAddPreset;
        private System.Windows.Forms.Button btnGetPresetList;
        private System.Windows.Forms.GroupBox grpMediaControl;
        private System.Windows.Forms.Button btnGetRtspUrl;
        private System.Windows.Forms.Label lblCamera;
        private System.Windows.Forms.ComboBox cbxCameras;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtRtspUrl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblPtzSpeed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button clearLog;
    }
}