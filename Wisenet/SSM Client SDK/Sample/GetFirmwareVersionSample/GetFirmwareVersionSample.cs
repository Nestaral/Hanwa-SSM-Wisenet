using Newtonsoft.Json;
using SampleLogLib;
using SdkWrapper;
using System;
using System.Windows.Forms;

namespace GetFirmwareVersionSample
{
    public partial class GetFirmwareVersionSample : Form
    {
        enum CommandID { GetFirmwareVersion = 10004, }
        enum EventID { Login = 11, LogOut = 12 }

        private DebugLog _logger;
        private SsmSdkWrapper ssmSdkWrapper = null;
        private bool islogin = false;

        public GetFirmwareVersionSample()
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

            if (commandID == (uint)CommandID.GetFirmwareVersion)
            {
                UpdateFirmwareVersion(info);
            }
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

        private void GetFirmwareVersionSample_Load(object sender, EventArgs e)
        {
            ssmSdkWrapper = new SsmSdkWrapper(this.OnResponse, this.OnEvent);
            ssmSdkWrapper.InitializeEvent();
        }

        private void GetFirmwareVersionSample_Closed(object sender, EventArgs e)
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            uint resCode = ssmSdkWrapper.GetFirmwareVersion(
                txtGuid.Text);

            _logger.WLOGD("Print()::Result=" + resCode);
        }

        private void UpdateFirmwareVersion(String info)
        {
            FirmwareVersionModel firmwareVersionModel = JsonConvert.DeserializeObject<FirmwareVersionModel>(info);

            this.txtModelName.Text = firmwareVersionModel.Model;
            this.txtFirmwareVersion.Text = firmwareVersionModel.FirmwareVersion;
        }

        private void clearLog_Click(object sender, EventArgs e)
        {
            _logger.ClearLog();
        }
    }

    public class FirmwareVersionModel
    {
        public string Guid { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string FirmwareVersion { get; set; }
    }
}