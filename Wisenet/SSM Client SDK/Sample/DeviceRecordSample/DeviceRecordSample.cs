using SampleLogLib;
using SdkWrapper;
using System;
using System.Windows.Forms;

namespace DeviceRecordSample
{
    public partial class DeviceRecordSample : Form
    {
        enum EventID { Login = 11, LogOut = 12 }

        private DebugLog _logger;
        private SsmSdkWrapper ssmSdkWrapper = null;
        private bool islogin = false;

        public DeviceRecordSample()
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
             " Info=" + info.ToString());

            if (eventID == (uint)EventID.Login)
            {
                islogin = true;
            }
            else if (eventID == (uint)EventID.LogOut)
            {
                islogin = false;
            }
        }

        private void DeviceRecordSample_Load(object sender, EventArgs e)
        {
            ssmSdkWrapper = new SsmSdkWrapper(this.OnResponse, this.OnEvent);
            ssmSdkWrapper.InitializeEvent();
        }

        private void DeviceRecordSample_Closed(object sender, EventArgs e)
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

        private void btnRecordStart_Click(object sender, EventArgs e)
        {
            String guidText = textBoxUnitID.Text;
            Guid guid = Guid.Empty;
            UInt32 sequenceID = 0;

            if (Guid.TryParse(guidText, out guid))
            {
                uint resCode = ssmSdkWrapper.StartDeviceRecording(textBoxUnitID.Text, ref sequenceID);
                _logger.WLOGD("StartDeviceRecording()::Result=" + resCode + ", SequenceID=" + sequenceID);
            }
            else
            {
                MessageBox.Show("Check the guid.");
            }
        }

        private void btnRecordStop_Click(object sender, EventArgs e)
        {
            String guidText = textBoxUnitID.Text;
            Guid guid = Guid.Empty;
            UInt32 sequenceID = 0;

            if (Guid.TryParse(guidText, out guid))
            {
                uint resCode = ssmSdkWrapper.StopDeviceRecording(textBoxUnitID.Text, ref sequenceID);
                _logger.WLOGD("StopDeviceRecording()::Result=" + resCode + ", SequenceID=" + sequenceID);
            }
            else
            {
                MessageBox.Show("Check the guid.");
            }
        }

        private void btnGetObjects_Click(object sender, EventArgs e)
        {
            String json = ssmSdkWrapper.GetObjectList();

            _logger.WLOGD("GetObjectList()::Json=>" + json);
        }

        private void clearLog_Click(object sender, EventArgs e)
        {
            _logger.ClearLog();
        }
    }
}