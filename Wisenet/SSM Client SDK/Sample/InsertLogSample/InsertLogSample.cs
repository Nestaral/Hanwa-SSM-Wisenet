using Newtonsoft.Json;
using SampleLogLib;
using SdkWrapper;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InsertLogSample
{
    public partial class InsertLogSample : Form
    {
        enum EventID { Login = 11, LogOut = 12 }

        private string _deviceUuid, _deviceName;
        private string _cameraUuid, _cameraName;
        private string _logType;
        private DebugLog _logger;
        private List<ObjectInfo> _cameraList, _deviceList;
        private Dictionary<string, uint> _logTypeDictionary;
        private SsmSdkWrapper ssmSdkWrapper = null;

        private bool islogin = false;

        public InsertLogSample()
        {
            InitializeComponent();
            _logger = new DebugLog(txtStatus);
            _cameraList = new List<ObjectInfo>();
            _deviceList = new List<ObjectInfo>();

            _logTypeDictionary = new Dictionary<string, uint>()
            {
                {"MOTION_DETECT", 4001},
                {"ASSET_PROTECTION (Agent VI)", 4045},
                {"CAMERA_TEMPERING (Agent VI)", 4046},
                {"CROWD_DETECTION (Agent VI)", 4047},
                {"LOITERING (Agent VI)", 4048},
                {"OCCUPANCY (Agent VI)", 4049},
                {"STERILE_ZONE (Agent VI)", 4050},
                {"STOPPED_VEHICLE (Agent VI)", 4051},
                {"SUSPICIOUS_OBJECT (Agent VI)", 4052},
                {"THERMAL_CAMERA (Agent VI)", 4053},
                {"VEHICLE_TAILGATING (Agent VI)", 4054},
                {"INTRUSION_DETECT", 5500},
                {"CROWD_DETECTION", 4047},
                {"FOG_DETECTION", 4059},
                {"EXTERNAL", 10000}
            };

        }

        private void InsertLogSample_Load(object sender, EventArgs e)
        {
            ssmSdkWrapper = new SsmSdkWrapper(this.OnResponse, this.OnEvent);
            ssmSdkWrapper.InitializeEvent();
            cbxLogType.SelectedIndex = 0;
        }

        private void InsertLogSample_Closed(object sender, FormClosingEventArgs e)
        {
            if (islogin)
            {
                uint resCode = ssmSdkWrapper.Logout();
                _logger.WLOGD("Logout()::Result=" + resCode);
            }

            ssmSdkWrapper.ReleaseEvent();
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
                SetObjectList(info);
                UpdateComboDevices();
                UpdateComboCameras();
            }
            else if (eventID == (uint)EventID.LogOut)
            {
                islogin = false;
            }
        }

        private void SetObjectList(string message)
        {
            try
            {
                dynamic deserialized = JsonConvert.DeserializeObject(message);
                string objects = Convert.ToString(deserialized["Objects"]);
                var objectList = JsonConvert.DeserializeObject<List<ObjectInfo>>(objects);
                foreach (var device in objectList)
                {
                    if (device.Type.CompareTo("Device") == 0 && device.NameExt != null)
                        _deviceList.Add(device);
                    if (device.Type.CompareTo("Camera") == 0)
                        _cameraList.Add(device);
                }
                _cameraList.Sort((x, y) => x.NameAddress.CompareTo(y.NameAddress));
                _deviceList.Sort((x, y) => x.NameAddress.CompareTo(y.NameAddress));
            }
            catch (Exception ex)
            {
                _logger.WLOGD(ex.Message);
            }
        }

        private void UpdateComboDevices()
        {
            try
            {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = _deviceList;
                cbxDevices.Invoke(new MethodInvoker(
                    delegate ()
                    {
                        cbxDevices.DataSource = bindingSource.DataSource;
                        cbxDevices.DisplayMember = "NameAddress";
                        cbxDevices.ValueMember = "Guid";
                    }));
            }
            catch (Exception ex)
            {
                _logger.WLOGD(ex.Message);
            }
        }

        private void UpdateComboCameras()
        {
            try
            {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = _cameraList;
                cbxCameras.Invoke(new MethodInvoker(
                    delegate ()
                    {
                        cbxCameras.DataSource = bindingSource.DataSource;
                        cbxCameras.DisplayMember = "NameAddress";
                        cbxCameras.ValueMember = "Guid";
                    }));
            }
            catch (Exception ex)
            {
                _logger.WLOGD(ex.Message);
            }
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

        private void btnInsertLog_Click(object sender, EventArgs e)
        {
            uint resCode = 0;
            UInt32 sequenceID = 0;
            try
            {
                resCode = ssmSdkWrapper.InsertExternalLog(
                _deviceUuid,
                _cameraUuid,
                _logTypeDictionary[_logType],
                ref sequenceID);
            }
            catch (Exception ex)
            {
                _logger.WLOGD(ex.Message);
            }
            _logger.WLOGD("InsertLog()::Result=" + resCode + ", SequenceID=" + sequenceID);
        }

        private void btnInsertLogWithEventKey_Click(object sender, EventArgs e)
        {
            uint resCode = 0;
            UInt32 sequenceID = 0;

            UInt32 eventKey = 0;
            string eventLog = this.txtEventLog.Text;

            if (!UInt32.TryParse(this.txtEventKey.Text, out eventKey))
            {
                _logger.WLOGD("[ERROR] Check Event Key");
                return;
            }

            try
            {
                resCode = ssmSdkWrapper.InsertExternalANPREventKey(
                _deviceUuid,
                _cameraUuid,
                eventKey,
                eventLog,
                ref sequenceID);
            }
            catch (Exception ex)
            {
                _logger.WLOGD(ex.Message);
            }
            _logger.WLOGD("InsertLog()::Result=" + resCode + ", SequenceID=" + sequenceID);
        }

        private void clearLog_Click(object sender, EventArgs e)
        {
            _logger.ClearLog();
        }

        private void cbxDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDevices.SelectedIndex < 0)
                return;

            var selected = cbxDevices.SelectedItem as ObjectInfo;
            _deviceUuid = selected.Guid;
            _deviceName = selected.Name;
        }

        private void cbxCameras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCameras.SelectedIndex < 0)
                return;

            var selected = cbxCameras.SelectedItem as ObjectInfo;
            _cameraUuid = selected.Guid;
            _cameraName = selected.Name;
        }

        private void cbxLogType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLogType.SelectedIndex < 0)
                return;

            _logType = cbxLogType.SelectedItem.ToString();
        }
    }
}