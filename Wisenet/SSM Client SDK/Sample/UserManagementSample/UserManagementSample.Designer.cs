namespace UserManagementSample
{
    partial class UserManagementSample
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxDeleteUserGuid = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUserList = new System.Windows.Forms.TextBox();
            this.textBoxUserGroupList = new System.Windows.Forms.TextBox();
            this.PrintUsers = new System.Windows.Forms.Button();
            this.PrintUserGroup = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ModifyUsergroupButton = new System.Windows.Forms.Button();
            this.textBoxModifyUsergroupDescription = new System.Windows.Forms.TextBox();
            this.AddUsergroupButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxAddUsergroupName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxModifyUsergroupGuid = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxDeleteUsergroupGuid = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DeleteUsergroupButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxAddUserDescription = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxAddUserEmail = new System.Windows.Forms.TextBox();
            this.textBoxAddUserAddress = new System.Windows.Forms.TextBox();
            this.textBoxAddUserPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxAddUserName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAddUserParentGuid = new System.Windows.Forms.TextBox();
            this.textBoxModifyUserGuid = new System.Windows.Forms.TextBox();
            this.textBoxAddUserPassword = new System.Windows.Forms.TextBox();
            this.ModifyUserButton = new System.Windows.Forms.Button();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.textBoxAddUserID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.clearLog = new System.Windows.Forms.Button();
            this.grpLoginInfo.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.txtLog.Location = new System.Drawing.Point(12, 228);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(405, 408);
            this.txtLog.TabIndex = 33;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(12, 200);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(26, 12);
            this.lblLog.TabIndex = 34;
            this.lblLog.Text = "Log";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxDeleteUserGuid);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.DeleteUserButton);
            this.groupBox6.Location = new System.Drawing.Point(878, 587);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(405, 59);
            this.groupBox6.TabIndex = 46;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Delete user";
            // 
            // textBoxDeleteUserGuid
            // 
            this.textBoxDeleteUserGuid.Location = new System.Drawing.Point(50, 22);
            this.textBoxDeleteUserGuid.Name = "textBoxDeleteUserGuid";
            this.textBoxDeleteUserGuid.Size = new System.Drawing.Size(241, 21);
            this.textBoxDeleteUserGuid.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(13, 25);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 12);
            this.label23.TabIndex = 2;
            this.label23.Text = "Guid";
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.Location = new System.Drawing.Point(297, 13);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(98, 36);
            this.DeleteUserButton.TabIndex = 0;
            this.DeleteUserButton.Text = "Delete";
            this.DeleteUserButton.UseVisualStyleBackColor = true;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(876, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 12);
            this.label7.TabIndex = 40;
            this.label7.Text = "User";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 12);
            this.label5.TabIndex = 41;
            this.label5.Text = "Usergroup";
            // 
            // textBoxUserList
            // 
            this.textBoxUserList.Location = new System.Drawing.Point(878, 33);
            this.textBoxUserList.Multiline = true;
            this.textBoxUserList.Name = "textBoxUserList";
            this.textBoxUserList.ReadOnly = true;
            this.textBoxUserList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxUserList.Size = new System.Drawing.Size(405, 146);
            this.textBoxUserList.TabIndex = 38;
            // 
            // textBoxUserGroupList
            // 
            this.textBoxUserGroupList.Location = new System.Drawing.Point(434, 33);
            this.textBoxUserGroupList.Multiline = true;
            this.textBoxUserGroupList.Name = "textBoxUserGroupList";
            this.textBoxUserGroupList.ReadOnly = true;
            this.textBoxUserGroupList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxUserGroupList.Size = new System.Drawing.Size(403, 146);
            this.textBoxUserGroupList.TabIndex = 39;
            // 
            // PrintUsers
            // 
            this.PrintUsers.Location = new System.Drawing.Point(1175, 185);
            this.PrintUsers.Name = "PrintUsers";
            this.PrintUsers.Size = new System.Drawing.Size(108, 36);
            this.PrintUsers.TabIndex = 36;
            this.PrintUsers.Text = "Print Users";
            this.PrintUsers.UseVisualStyleBackColor = true;
            this.PrintUsers.Click += new System.EventHandler(this.PrintUsers_Click);
            // 
            // PrintUserGroup
            // 
            this.PrintUserGroup.Location = new System.Drawing.Point(729, 185);
            this.PrintUserGroup.Name = "PrintUserGroup";
            this.PrintUserGroup.Size = new System.Drawing.Size(108, 36);
            this.PrintUserGroup.TabIndex = 37;
            this.PrintUserGroup.Text = "Print Usergroups";
            this.PrintUserGroup.UseVisualStyleBackColor = true;
            this.PrintUserGroup.Click += new System.EventHandler(this.PrintUserGroup_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ModifyUsergroupButton);
            this.groupBox1.Controls.Add(this.textBoxModifyUsergroupDescription);
            this.groupBox1.Controls.Add(this.AddUsergroupButton);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxAddUsergroupName);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxModifyUsergroupGuid);
            this.groupBox1.Location = new System.Drawing.Point(434, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 251);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add, Modify usergroup";
            // 
            // ModifyUsergroupButton
            // 
            this.ModifyUsergroupButton.Location = new System.Drawing.Point(287, 199);
            this.ModifyUsergroupButton.Name = "ModifyUsergroupButton";
            this.ModifyUsergroupButton.Size = new System.Drawing.Size(108, 36);
            this.ModifyUsergroupButton.TabIndex = 0;
            this.ModifyUsergroupButton.Text = "Modify";
            this.ModifyUsergroupButton.UseVisualStyleBackColor = true;
            this.ModifyUsergroupButton.Click += new System.EventHandler(this.ModifyUsergroupButton_Click);
            // 
            // textBoxModifyUsergroupDescription
            // 
            this.textBoxModifyUsergroupDescription.Location = new System.Drawing.Point(86, 113);
            this.textBoxModifyUsergroupDescription.Multiline = true;
            this.textBoxModifyUsergroupDescription.Name = "textBoxModifyUsergroupDescription";
            this.textBoxModifyUsergroupDescription.Size = new System.Drawing.Size(171, 116);
            this.textBoxModifyUsergroupDescription.TabIndex = 3;
            // 
            // AddUsergroupButton
            // 
            this.AddUsergroupButton.Location = new System.Drawing.Point(287, 151);
            this.AddUsergroupButton.Name = "AddUsergroupButton";
            this.AddUsergroupButton.Size = new System.Drawing.Size(108, 36);
            this.AddUsergroupButton.TabIndex = 0;
            this.AddUsergroupButton.Text = "Add";
            this.AddUsergroupButton.UseVisualStyleBackColor = true;
            this.AddUsergroupButton.Click += new System.EventHandler(this.AddUsergroupButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "Name";
            // 
            // textBoxAddUsergroupName
            // 
            this.textBoxAddUsergroupName.Location = new System.Drawing.Point(86, 27);
            this.textBoxAddUsergroupName.Name = "textBoxAddUsergroupName";
            this.textBoxAddUsergroupName.Size = new System.Drawing.Size(232, 21);
            this.textBoxAddUsergroupName.TabIndex = 3;
            this.textBoxAddUsergroupName.Text = "UserGroup1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "Guid (only modify)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "Description";
            // 
            // textBoxModifyUsergroupGuid
            // 
            this.textBoxModifyUsergroupGuid.Location = new System.Drawing.Point(86, 83);
            this.textBoxModifyUsergroupGuid.Name = "textBoxModifyUsergroupGuid";
            this.textBoxModifyUsergroupGuid.Size = new System.Drawing.Size(232, 21);
            this.textBoxModifyUsergroupGuid.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxDeleteUsergroupGuid);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.DeleteUsergroupButton);
            this.groupBox3.Location = new System.Drawing.Point(434, 492);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(403, 55);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete usergroup";
            // 
            // textBoxDeleteUsergroupGuid
            // 
            this.textBoxDeleteUsergroupGuid.Location = new System.Drawing.Point(49, 21);
            this.textBoxDeleteUsergroupGuid.Name = "textBoxDeleteUsergroupGuid";
            this.textBoxDeleteUsergroupGuid.Size = new System.Drawing.Size(224, 21);
            this.textBoxDeleteUsergroupGuid.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 12);
            this.label13.TabIndex = 2;
            this.label13.Text = "Guid";
            // 
            // DeleteUsergroupButton
            // 
            this.DeleteUsergroupButton.Location = new System.Drawing.Point(287, 12);
            this.DeleteUsergroupButton.Name = "DeleteUsergroupButton";
            this.DeleteUsergroupButton.Size = new System.Drawing.Size(108, 36);
            this.DeleteUsergroupButton.TabIndex = 0;
            this.DeleteUsergroupButton.Text = "Delete";
            this.DeleteUsergroupButton.UseVisualStyleBackColor = true;
            this.DeleteUsergroupButton.Click += new System.EventHandler(this.DeleteUsergroupButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxAddUserDescription);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.textBoxAddUserEmail);
            this.groupBox4.Controls.Add(this.textBoxAddUserAddress);
            this.groupBox4.Controls.Add(this.textBoxAddUserPhoneNumber);
            this.groupBox4.Controls.Add(this.textBoxAddUserName);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textBoxAddUserParentGuid);
            this.groupBox4.Controls.Add(this.textBoxModifyUserGuid);
            this.groupBox4.Controls.Add(this.textBoxAddUserPassword);
            this.groupBox4.Controls.Add(this.ModifyUserButton);
            this.groupBox4.Controls.Add(this.AddUserButton);
            this.groupBox4.Controls.Add(this.textBoxAddUserID);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(878, 227);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(405, 354);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add, Modify user";
            // 
            // textBoxAddUserDescription
            // 
            this.textBoxAddUserDescription.Location = new System.Drawing.Point(86, 188);
            this.textBoxAddUserDescription.Multiline = true;
            this.textBoxAddUserDescription.Name = "textBoxAddUserDescription";
            this.textBoxAddUserDescription.Size = new System.Drawing.Size(187, 48);
            this.textBoxAddUserDescription.TabIndex = 3;
            this.textBoxAddUserDescription.Text = "example";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 191);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(68, 12);
            this.label22.TabIndex = 2;
            this.label22.Text = "Description";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 12);
            this.label15.TabIndex = 2;
            this.label15.Text = "E-mail";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 12);
            this.label14.TabIndex = 2;
            this.label14.Text = "Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "Phone";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 84);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 12);
            this.label21.TabIndex = 2;
            this.label21.Text = "Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 250);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(230, 12);
            this.label17.TabIndex = 2;
            this.label17.Text = "Parent Guid (UserGroup guid, only add)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 295);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(111, 12);
            this.label20.TabIndex = 2;
            this.label20.Text = "Guid (only modify)";
            // 
            // textBoxAddUserEmail
            // 
            this.textBoxAddUserEmail.Location = new System.Drawing.Point(86, 161);
            this.textBoxAddUserEmail.Name = "textBoxAddUserEmail";
            this.textBoxAddUserEmail.Size = new System.Drawing.Size(187, 21);
            this.textBoxAddUserEmail.TabIndex = 3;
            this.textBoxAddUserEmail.Text = "example@example.com";
            // 
            // textBoxAddUserAddress
            // 
            this.textBoxAddUserAddress.Location = new System.Drawing.Point(86, 135);
            this.textBoxAddUserAddress.Name = "textBoxAddUserAddress";
            this.textBoxAddUserAddress.Size = new System.Drawing.Size(187, 21);
            this.textBoxAddUserAddress.TabIndex = 3;
            this.textBoxAddUserAddress.Text = "South Korea";
            // 
            // textBoxAddUserPhoneNumber
            // 
            this.textBoxAddUserPhoneNumber.Location = new System.Drawing.Point(86, 108);
            this.textBoxAddUserPhoneNumber.Name = "textBoxAddUserPhoneNumber";
            this.textBoxAddUserPhoneNumber.Size = new System.Drawing.Size(187, 21);
            this.textBoxAddUserPhoneNumber.TabIndex = 3;
            this.textBoxAddUserPhoneNumber.Text = "000-000-0000";
            // 
            // textBoxAddUserName
            // 
            this.textBoxAddUserName.Location = new System.Drawing.Point(86, 81);
            this.textBoxAddUserName.Name = "textBoxAddUserName";
            this.textBoxAddUserName.Size = new System.Drawing.Size(187, 21);
            this.textBoxAddUserName.TabIndex = 3;
            this.textBoxAddUserName.Text = "SSM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "Password";
            // 
            // textBoxAddUserParentGuid
            // 
            this.textBoxAddUserParentGuid.Location = new System.Drawing.Point(35, 265);
            this.textBoxAddUserParentGuid.Name = "textBoxAddUserParentGuid";
            this.textBoxAddUserParentGuid.Size = new System.Drawing.Size(238, 21);
            this.textBoxAddUserParentGuid.TabIndex = 3;
            // 
            // textBoxModifyUserGuid
            // 
            this.textBoxModifyUserGuid.Location = new System.Drawing.Point(35, 310);
            this.textBoxModifyUserGuid.Name = "textBoxModifyUserGuid";
            this.textBoxModifyUserGuid.Size = new System.Drawing.Size(238, 21);
            this.textBoxModifyUserGuid.TabIndex = 3;
            // 
            // textBoxAddUserPassword
            // 
            this.textBoxAddUserPassword.Location = new System.Drawing.Point(86, 54);
            this.textBoxAddUserPassword.Name = "textBoxAddUserPassword";
            this.textBoxAddUserPassword.Size = new System.Drawing.Size(187, 21);
            this.textBoxAddUserPassword.TabIndex = 3;
            this.textBoxAddUserPassword.Text = "init123!!";
            // 
            // ModifyUserButton
            // 
            this.ModifyUserButton.Location = new System.Drawing.Point(287, 301);
            this.ModifyUserButton.Name = "ModifyUserButton";
            this.ModifyUserButton.Size = new System.Drawing.Size(108, 36);
            this.ModifyUserButton.TabIndex = 0;
            this.ModifyUserButton.Text = "Modify";
            this.ModifyUserButton.UseVisualStyleBackColor = true;
            this.ModifyUserButton.Click += new System.EventHandler(this.ModifyUserButton_Click);
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(287, 256);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(108, 36);
            this.AddUserButton.TabIndex = 0;
            this.AddUserButton.Text = "Add";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // textBoxAddUserID
            // 
            this.textBoxAddUserID.Location = new System.Drawing.Point(86, 24);
            this.textBoxAddUserID.Name = "textBoxAddUserID";
            this.textBoxAddUserID.Size = new System.Drawing.Size(187, 21);
            this.textBoxAddUserID.TabIndex = 3;
            this.textBoxAddUserID.Text = "user1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 12);
            this.label16.TabIndex = 2;
            this.label16.Text = "ID";
            // 
            // clearLog
            // 
            this.clearLog.Location = new System.Drawing.Point(344, 194);
            this.clearLog.Name = "clearLog";
            this.clearLog.Size = new System.Drawing.Size(73, 25);
            this.clearLog.TabIndex = 47;
            this.clearLog.Text = "Clear";
            this.clearLog.UseVisualStyleBackColor = true;
            this.clearLog.Click += new System.EventHandler(this.clearLog_Click);
            // 
            // UserManagementSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 661);
            this.Controls.Add(this.clearLog);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxUserList);
            this.Controls.Add(this.textBoxUserGroupList);
            this.Controls.Add(this.PrintUsers);
            this.Controls.Add(this.PrintUserGroup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.grpLoginInfo);
            this.Name = "UserManagementSample";
            this.Text = "UserManagement Sample";
            this.Closed += new System.EventHandler(this.UserManagementSample_Closed);
            this.Load += new System.EventHandler(this.UserManagementSample_Load);
            this.grpLoginInfo.ResumeLayout(false);
            this.grpLoginInfo.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBoxDeleteUserGuid;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUserList;
        private System.Windows.Forms.TextBox textBoxUserGroupList;
        private System.Windows.Forms.Button PrintUsers;
        private System.Windows.Forms.Button PrintUserGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxAddUsergroupName;
        private System.Windows.Forms.Button AddUsergroupButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ModifyUsergroupButton;
        private System.Windows.Forms.TextBox textBoxModifyUsergroupGuid;
        private System.Windows.Forms.TextBox textBoxModifyUsergroupDescription;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxDeleteUsergroupGuid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button DeleteUsergroupButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxAddUserDescription;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxAddUserEmail;
        private System.Windows.Forms.TextBox textBoxAddUserAddress;
        private System.Windows.Forms.TextBox textBoxAddUserPhoneNumber;
        private System.Windows.Forms.TextBox textBoxAddUserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAddUserParentGuid;
        private System.Windows.Forms.TextBox textBoxModifyUserGuid;
        private System.Windows.Forms.TextBox textBoxAddUserPassword;
        private System.Windows.Forms.Button ModifyUserButton;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.TextBox textBoxAddUserID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button clearLog;
    }
}