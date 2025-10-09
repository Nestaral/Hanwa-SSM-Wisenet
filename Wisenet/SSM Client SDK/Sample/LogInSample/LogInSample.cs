using SampleLogLib;
using SdkWrapper;
using System;
using System.Windows.Forms;

namespace LoginSample
{
    public partial class LoginSample : Form
    {
        private DebugLog _logger;
        private SsmSdkWrapper ssmSdkWrapper = null;

        public LoginSample()
        {
            InitializeComponent();
            _logger = new DebugLog(txtLog);
        }

        private void OnResponse(UInt32 commandID, UInt32 errorCode, UInt32 sequenceID, string info)
        {
            String logMessage = "OnResponse()::" +
             " Command ID=" + commandID +
             " Result=" + errorCode +
             " Sequence ID= " + sequenceID +
             " Info=" + info;
            _logger.WLOGD(logMessage);

            System.Diagnostics.Trace.WriteLine(logMessage);
        }

        private void OnEvent(UInt32 eventID, String info)
        {
            String logMessage = "OnEvent()::" +
                   " Event ID=" + eventID +
                   " Info=" + info;
            _logger.WLOGD(logMessage);

            System.Diagnostics.Trace.WriteLine(logMessage);
        }

        private void LoginSample_Load(object sender, EventArgs e)
        {
            ssmSdkWrapper = new SsmSdkWrapper(this.OnResponse, this.OnEvent);
            ssmSdkWrapper.InitializeEvent();
        }

        private void LoginSample_Closed(object sender, EventArgs e)
        {
            uint resCode = ssmSdkWrapper.Logout();
            _logger.WLOGD("Logout()::Result=" + resCode);

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

        private void btnGetObjects_Click(object sender, EventArgs e)
        {
            String json = ssmSdkWrapper.GetObjectList();

            _logger.WLOGD("GetObjectList()::Json=>" + json);
        }

        private void btnGetObject_Click(object sender, EventArgs e)
        {
            Guid uid = Guid.Empty;
            if(Guid.TryParse(txtGuid.Text, out uid))
            {
                String json = ssmSdkWrapper.GetObject(txtGuid.Text);

                _logger.WLOGD("GetObject()::Json=>" + json);
            }
            else
            {
                _logger.WLOGD("Wrong guid");
            }
        }

        private void clearLog_Click(object sender, EventArgs e)
        {
            _logger.ClearLog();
        }
    }
}