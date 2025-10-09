using Newtonsoft.Json;
using SampleLogLib;
using SdkWrapper;
using System;
using System.Windows.Forms;

namespace LiveLocalRecordSample
{
    public partial class LiveLocalRecordSample : Form
    {
        enum EventID { Login = 11, LogOut = 12 }

        private DebugLog _logger;
        private SsmSdkWrapper ssmSdkWrapper = null;
        private bool islogin = false;

        public LiveLocalRecordSample()
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

        private void LiveLocalRecordSample_Load(object sender, EventArgs e)
        {
            ssmSdkWrapper = new SsmSdkWrapper(this.OnResponse, this.OnEvent);
            ssmSdkWrapper.InitializeEvent();
        }

        private void LiveLocalRecordSample_Closed(object sender, EventArgs e)
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
            uint resCode = 0;
            UInt32 sequenceID = 0;

            if (Guid.TryParse(guidText, out guid))
            {
                LocalRecordModel localRecordModel = new LocalRecordModel();

                localRecordModel.CameraGuid = textBoxUnitID.Text;
                localRecordModel.ProfileType = 1; // HIGH
                localRecordModel.FilePath = textBoxFilePath.Text;
                localRecordModel.FileName = textBoxFileName.Text;

                String json = JsonConvert.SerializeObject(localRecordModel, Formatting.Indented);

                resCode = ssmSdkWrapper.StartLiveLocalRecording(json, ref sequenceID);
                _logger.WLOGD("StartLiveLocalRecording()::Result=" + resCode + ", SequenceID=" + sequenceID);
            }
            else
            {
                MessageBox.Show("Check the guid");
            }
        }

        private void btnRecordStop_Click(object sender, EventArgs e)
        {
            String guidText = textBoxUnitID.Text;
            Guid guid = Guid.Empty;
            uint resCode = 0;
            UInt32 sequenceID = 0;

            if (Guid.TryParse(guidText, out guid))
            {
                LocalRecordModel localRecordModel = new LocalRecordModel();

                localRecordModel.CameraGuid = textBoxUnitID.Text;
                localRecordModel.ProfileType = 1; // HIGH

                String json = JsonConvert.SerializeObject(localRecordModel, Formatting.Indented);

                resCode = ssmSdkWrapper.StopLiveLocalRecording(json, ref sequenceID);
                _logger.WLOGD("StopLiveLocalRecording()::Result=" + resCode + ", SequenceID=" + sequenceID);
            }
            else
            {
                MessageBox.Show("Check the guid");
            }
        }

        private void clearLog_Click(object sender, EventArgs e)
        {
            _logger.ClearLog();
        }
    }

    public class LocalRecordModel
    {
        public String CameraGuid;
        public Int32 ProfileType;
        public String FilePath;
        public String FileName;
    }
}