using Newtonsoft.Json;
using SampleLogLib;
using SdkWrapper;
using System;
using System.Windows.Forms;

namespace NtpSample
{
    public partial class NtpSample : Form
    {
        enum CommandID { GetNtp = 10005, SetNtp = 10006 }
        enum EventID { Login = 11, LogOut = 12 }

        private DebugLog _logger;
        private SsmSdkWrapper ssmSdkWrapper = null;
        private bool islogin = false;

        public NtpSample()
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

            if (commandID == (uint)CommandID.GetNtp)
            {
                UpdateNtp(info);
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

        private void NtpSample_Load(object sender, EventArgs e)
        {
            ssmSdkWrapper = new SsmSdkWrapper(this.OnResponse, this.OnEvent);
            ssmSdkWrapper.InitializeEvent();
        }

        private void NtpSample_Closed(object sender, EventArgs e)
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

        public delegate void DeleUpdateNtp(String json);
        private void UpdateNtp(String json)
        {
            NtpInfoModel ntpInfoModel = JsonConvert.DeserializeObject<NtpInfoModel>(json);

            if (this.InvokeRequired)
            {
                DeleUpdateNtp deUpdateNtp = new DeleUpdateNtp(this.UpdateNtp);
                this.Invoke(deUpdateNtp, new object[] { json });
                return;
            }
            else
            {
                this.ntpServerEnable.Checked = ntpInfoModel.NtpServerEnabled;
                this.ntpHost.Checked = ntpInfoModel.NtpEnabled;
                this.textBoxNtpHost.Text = ntpInfoModel.NtpHostName;
                this.textBoxLastSyncTime.Text = ntpInfoModel.LastSyncTime;
                this.textBoxSyncInterval.Text = ntpInfoModel.NtpSyncIntervalMinute.ToString();
            }
        }

        private void NtpGet_Click(object sender, EventArgs e)
        {
            UInt32 sequenceID = 0;
            UInt32 resCode = 0;

            resCode = ssmSdkWrapper.GetNtp(ref sequenceID);

            _logger.WLOGD("GetNtp()::Result=" + resCode + ", SequenceID=" + sequenceID);
        }

        private void NtpSet_Click(object sender, EventArgs e)
        {
            String json = String.Empty;
            UInt32 sequenceID = 0;
            UInt32 resCode = 0;

            NtpInfoModel ntpInfoModel = new NtpInfoModel();

            ntpInfoModel.NtpServerEnabled = this.ntpServerEnable.Checked;
            ntpInfoModel.NtpEnabled = this.ntpHost.Checked;
            ntpInfoModel.NtpHostName = this.textBoxNtpHost.Text;

            Int32 interval = 0;
            Int32.TryParse(textBoxSyncInterval.Text, out interval);
            ntpInfoModel.NtpSyncIntervalMinute = interval;

            json = JsonConvert.SerializeObject(ntpInfoModel, Formatting.Indented);

            resCode = ssmSdkWrapper.SetNtp(json, ref sequenceID);

            _logger.WLOGD("SetNtp()::Result=" + resCode + ", SequenceID=" + sequenceID);
        }

        private void clearLog_Click(object sender, EventArgs e)
        {
            _logger.ClearLog();
        }
    }

    public class NtpInfoModel
    {
        public Boolean NtpServerEnabled { get; set; }
        public Boolean NtpEnabled { get; set; }
        public String NtpHostName { get; set; }
        public String LastSyncTime { get; set; }
        public Int32 NtpSyncIntervalMinute { get; set; }
    }
}