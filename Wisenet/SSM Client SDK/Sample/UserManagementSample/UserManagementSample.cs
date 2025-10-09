using Newtonsoft.Json;
using SampleLogLib;
using SdkWrapper;
using System;
using System.Windows.Forms;

namespace UserManagementSample
{
    public partial class UserManagementSample : Form
    {
        enum CommandID { GetFirmwareVersion = 10004, }
        enum EventID { Login = 11, LogOut = 12 }

        private DebugLog _logger;
        private SsmSdkWrapper ssmSdkWrapper = null;
        private bool islogin = false;

        public UserManagementSample()
        {
            InitializeComponent();
            _logger = new DebugLog(txtLog);
        }

        private void OnResponse(UInt32 commandID, UInt32 errorCode, UInt32 sequenceID, string info)
        {
            _logger.WLOGD(
             "OnResponse()::" +
             " Command ID=" + commandID +
             " Result=" + errorCode +
             " Sequence ID= " + sequenceID +
             " Info=" + info);
        }

        private void OnEvent(UInt32 eventID, String info)
        {
            _logger.WLOGD(
                "OnEvent()::" +
                " Event ID=" + eventID +
                " Info=" + info);

            if (eventID == (uint)EventID.Login)
            {
                islogin = true;
            }
            else if (eventID == (uint)EventID.LogOut)
            {
                islogin = false;
            }
        }

        private void UserManagementSample_Load(object sender, EventArgs e)
        {
            ssmSdkWrapper = new SsmSdkWrapper(this.OnResponse, this.OnEvent);
            ssmSdkWrapper.InitializeEvent();
        }

        private void UserManagementSample_Closed(object sender, EventArgs e)
        {
            if (islogin)
            {
                uint resCode = ssmSdkWrapper.Logout();
                _logger.WLOGD("Logout()::Result=" + resCode);
            }

            ssmSdkWrapper.ReleaseEvent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            uint resCode = ssmSdkWrapper.Login(
                txtID.Text,
                txtPassword.Text,
                txtIPAddress.Text,
                Convert.ToUInt32(txtPort.Text));
            _logger.WLOGD("Login()::Result=" + resCode);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            uint resCode = ssmSdkWrapper.Logout();
            _logger.WLOGD("Logout()::Result=" + resCode);
        }

        private void PrintUserGroup_Click(object sender, EventArgs e)
        {
            String str = ssmSdkWrapper.GetUserGroupInfo();

            this.textBoxUserGroupList.Text = str;
        }

        private void PrintUsers_Click(object sender, EventArgs e)
        {
            String str = ssmSdkWrapper.GetUserInfo();

            this.textBoxUserList.Text = str;
        }

        private void AddUsergroupButton_Click(object sender, EventArgs e)
        {
            UserGroupModel userGroupModel = new UserGroupModel();

            userGroupModel.Name = textBoxAddUsergroupName.Text;
            userGroupModel.Permission.MonitoringViewer = true;
            userGroupModel.Permission.Live = true;

            String json = JsonConvert.SerializeObject(userGroupModel, Formatting.Indented);
            UInt32 resCode = 0;
            UInt32 sequenceID = 0;

            resCode = ssmSdkWrapper.AddUserGroup(json, ref sequenceID);
            _logger.WLOGD("AddUserGroup()::Result=" + resCode + ", SequenceID=" + sequenceID);
        }

        private void ModifyUsergroupButton_Click(object sender, EventArgs e)
        {
            UserGroupModel userGroupModel = new UserGroupModel();

            userGroupModel.Guid = textBoxModifyUsergroupGuid.Text;
            userGroupModel.Name = textBoxAddUsergroupName.Text;
            userGroupModel.Description = textBoxModifyUsergroupDescription.Text;

            userGroupModel.Permission.MonitoringViewer = true;
            userGroupModel.Permission.Live = true;

            String json = JsonConvert.SerializeObject(userGroupModel, Formatting.Indented);
            UInt32 resCode = 0;
            UInt32 sequenceID = 0;

            resCode = ssmSdkWrapper.ModifyUserGroup(json, ref sequenceID);
            _logger.WLOGD("ModifyUserGroup()::Result=" + resCode + ", SequenceID=" + sequenceID);
        }

        private void DeleteUsergroupButton_Click(object sender, EventArgs e)
        {
            UserGroupModel userGroupModel = new UserGroupModel();

            userGroupModel.Guid = textBoxDeleteUsergroupGuid.Text;
            String json = JsonConvert.SerializeObject(userGroupModel, Formatting.Indented);
            UInt32 resCode = 0;
            UInt32 sequenceID = 0;

            resCode = ssmSdkWrapper.DeleteUserGroup(json, ref sequenceID);
            _logger.WLOGD("DeleteUserGroup()::Result=" + resCode + ", SequenceID=" + sequenceID);
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            if (textBoxAddUserID.Text == String.Empty)
            {
                MessageBox.Show("ID is empty.");
                return;
            }

            Guid usergroupGuid = Guid.Empty;
            if (!Guid.TryParse(textBoxAddUserParentGuid.Text, out usergroupGuid))
            {
                MessageBox.Show("Check parent guid(usergroup guid).");
                return;
            }

            UserModel userModel = new UserModel();
            userModel.UserGroupGuid = usergroupGuid.ToString();
            userModel.ID = textBoxAddUserID.Text;
            userModel.UserName = textBoxAddUserName.Text;
            userModel.Password = textBoxAddUserPassword.Text;
            userModel.PhoneNumber = textBoxAddUserPhoneNumber.Text;
            userModel.Email = textBoxAddUserEmail.Text;
            userModel.Address = textBoxAddUserAddress.Text;
            userModel.Description = textBoxAddUserDescription.Text;

            String json = JsonConvert.SerializeObject(userModel, Formatting.Indented);
            UInt32 resCode = 0;
            UInt32 sequenceID = 0;

            resCode = ssmSdkWrapper.AddUser(json, ref sequenceID);
            _logger.WLOGD("AddUser()::Result=" + resCode + ", SequenceID=" + sequenceID);
        }

        private void ModifyUserButton_Click(object sender, EventArgs e)
        {
            if (textBoxAddUserID.Text == String.Empty)
            {
                MessageBox.Show("ID is empty.");
                return;
            }

            Guid userGuid = Guid.Empty;
            if (!Guid.TryParse(textBoxModifyUserGuid.Text, out userGuid))
            {
                MessageBox.Show("Check guid.");
                return;
            }

            UserModel userModel = new UserModel();
            userModel.Guid = userGuid.ToString();
            userModel.ID = textBoxAddUserID.Text;
            userModel.UserName = textBoxAddUserName.Text;
            userModel.Password = textBoxAddUserPassword.Text;
            userModel.PhoneNumber = textBoxAddUserPhoneNumber.Text;
            userModel.Email = textBoxAddUserEmail.Text;
            userModel.Address = textBoxAddUserAddress.Text;
            userModel.Description = textBoxAddUserDescription.Text;

            String json = JsonConvert.SerializeObject(userModel, Formatting.Indented);
            UInt32 resCode = 0;
            UInt32 sequenceID = 0;

            resCode = ssmSdkWrapper.ModifyUser(json, ref sequenceID);
            _logger.WLOGD("ModifyUser()::Result=" + resCode + ", SequenceID=" + sequenceID);
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            UserModel userModel = new UserModel();

            userModel.Guid = textBoxDeleteUserGuid.Text;
            String json = JsonConvert.SerializeObject(userModel, Formatting.Indented);
            UInt32 resCode = 0;
            UInt32 sequenceID = 0;

            resCode = ssmSdkWrapper.DeleteUser(json, ref sequenceID);
            _logger.WLOGD("DeleteUser()::Result=" + resCode + ", SequenceID=" + sequenceID);
        }

        private void clearLog_Click(object sender, EventArgs e)
        {
            _logger.ClearLog();
        }
    }

    public class UserModel
    {
        public String Guid { get; set; }
        public String UserGroupGuid { get; set; }
        public String ID { get; set; }
        public String Password { get; set; }
        public String UserName { get; set; }
        public String PhoneNumber { get; set; }
        public String Email { get; set; }
        public String Address { get; set; }
        public String Description { get; set; }
    }

    public class UserGroupModel
    {
        public String Guid { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }

        public UserGroupPermission Permission = new UserGroupPermission();
        public class UserGroupPermission
        {
            public bool PTZ { get; set; }
            public bool EventConfirm { get; set; }
            public bool Print { get; set; }
            public bool LocalRecord { get; set; }
            public bool DeviceRecord { get; set; }
            public bool AlarmOut { get; set; }
            public bool CovertMonitoring { get; set; }
            public bool PrivacyMask { get; set; }
            public bool DeviceControl { get; set; }
            public bool Live { get; set; }
            public bool Playback { get; set; }
            public bool Backup { get; set; }
            public bool ScheduledBackup { get; set; }
            public bool MonitoringViewer { get; set; }
            public bool SearchViewer { get; set; }
            public bool EventViewer { get; set; }
            public bool PlugInViewer { get; set; }
            public bool ConfigrationViewer { get; set; }
            public bool RetailViewer { get; set; }
            public bool Dashboard { get; set; }
            public bool MobileViewer { get; set; }
            public bool VideoWall { get; set; }
        }
    }
}