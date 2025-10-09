namespace DdnsLogInSample
{
    partial class DdnsLogInSample
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
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtDdnsId = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.btnGetObjects = new System.Windows.Forms.Button();
            this.clearLog = new System.Windows.Forms.Button();
            this.grpLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLoginInfo
            // 
            this.grpLoginInfo.Controls.Add(this.btnLogout);
            this.grpLoginInfo.Controls.Add(this.lblIPAddress);
            this.grpLoginInfo.Controls.Add(this.btnLogin);
            this.grpLoginInfo.Controls.Add(this.lblPassword);
            this.grpLoginInfo.Controls.Add(this.txtDdnsId);
            this.grpLoginInfo.Controls.Add(this.txtPassword);
            this.grpLoginInfo.Controls.Add(this.txtID);
            this.grpLoginInfo.Controls.Add(this.lblID);
            this.grpLoginInfo.Location = new System.Drawing.Point(14, 12);
            this.grpLoginInfo.Name = "grpLoginInfo";
            this.grpLoginInfo.Size = new System.Drawing.Size(403, 158);
            this.grpLoginInfo.TabIndex = 32;
            this.grpLoginInfo.TabStop = false;
            this.grpLoginInfo.Text = "Login";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(309, 110);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(88, 36);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Location = new System.Drawing.Point(8, 24);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(101, 12);
            this.lblIPAddress.TabIndex = 12;
            this.lblIPAddress.Text = "Wisenet DDNS ID";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(215, 110);
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
            this.lblPassword.Location = new System.Drawing.Point(8, 86);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(62, 12);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password";
            // 
            // txtDdnsId
            // 
            this.txtDdnsId.Location = new System.Drawing.Point(123, 21);
            this.txtDdnsId.Name = "txtDdnsId";
            this.txtDdnsId.Size = new System.Drawing.Size(274, 21);
            this.txtDdnsId.TabIndex = 9;
            this.txtDdnsId.Text = "ddns";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(123, 83);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(274, 21);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "init123!!";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(123, 52);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(274, 21);
            this.txtID.TabIndex = 7;
            this.txtID.Text = "admin";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(8, 55);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(16, 12);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 251);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(405, 222);
            this.txtLog.TabIndex = 33;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(12, 229);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(26, 12);
            this.lblLog.TabIndex = 34;
            this.lblLog.Text = "Log";
            // 
            // btnGetObjects
            // 
            this.btnGetObjects.Location = new System.Drawing.Point(323, 176);
            this.btnGetObjects.Name = "btnGetObjects";
            this.btnGetObjects.Size = new System.Drawing.Size(88, 36);
            this.btnGetObjects.TabIndex = 15;
            this.btnGetObjects.Text = "Get Objects";
            this.btnGetObjects.UseVisualStyleBackColor = true;
            this.btnGetObjects.Click += new System.EventHandler(this.btnGetObject_Click);
            // 
            // clearLog
            // 
            this.clearLog.Location = new System.Drawing.Point(344, 220);
            this.clearLog.Name = "clearLog";
            this.clearLog.Size = new System.Drawing.Size(73, 25);
            this.clearLog.TabIndex = 47;
            this.clearLog.Text = "Clear";
            this.clearLog.UseVisualStyleBackColor = true;
            this.clearLog.Click += new System.EventHandler(this.clearLog_Click);
            // 
            // DdnsLogInSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 485);
            this.Controls.Add(this.clearLog);
            this.Controls.Add(this.btnGetObjects);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.grpLoginInfo);
            this.Name = "DdnsLogInSample";
            this.Text = "Wisenet DDNS Login Sample";
            this.Closed += new System.EventHandler(this.DdnsLogInSample_Closed);
            this.Load += new System.EventHandler(this.DdnsLogInSample_Load);
            this.grpLoginInfo.ResumeLayout(false);
            this.grpLoginInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLoginInfo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtDdnsId;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Button btnGetObjects;
        private System.Windows.Forms.Button clearLog;
    }
}