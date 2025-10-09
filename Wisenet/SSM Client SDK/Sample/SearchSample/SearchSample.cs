using Newtonsoft.Json;
using SampleLogLib;
using SdkWrapper;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SearchSample
{
    public partial class SearchSample : Form
    {
        enum EventID { Login = 11, LogOut = 12 }
        enum RecordType : uint { ALL = 4294967295, }
        enum IVEventType { ALL = 65535, }

        private const string UtcFormat = "yyyyMMddThhmmss";

        private string _deviceUuid, _deviceName;
        private string _cameraUuid, _cameraName;
        private DebugLog _logger;
        private List<ObjectInfo> _cameraList, _deviceList;
        private SsmSdkWrapper ssmSdkWrapper = null;
        private bool islogin = false;

        public SearchSample()
        {
            InitializeComponent();
            _logger = new DebugLog(txtStatus);
            _cameraList = new List<ObjectInfo>();
            _deviceList = new List<ObjectInfo>();
        }

        private void SearchSample_Load(object sender, EventArgs e)
        {
            ssmSdkWrapper = new SsmSdkWrapper(this.OnResponse, this.OnEvent);
            ssmSdkWrapper.InitializeEvent();
        }

        private void SearchSample_Closing(object sender, FormClosingEventArgs e)
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

        private void btnGetAuthority_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32 sequenceID = 0;
                uint result = ssmSdkWrapper.GetSearchAuthority(_deviceUuid, "", ref sequenceID);
                _logger.WLOGD("GetAuthority()::Result=" + result + ", SequenceID=" + sequenceID);
            }
            catch (Exception ex)
            {
                _logger.WLOGD(ex.Message);
            }
        }

        private void btnReleaseAuthority_Click(object sender, EventArgs e)
        {
            try
            {
                UInt32 sequenceID = 0;
                uint result = ssmSdkWrapper.ReleaseSearchAuthority(_deviceUuid, ref sequenceID);
                _logger.WLOGD("ReleaseAuthority()::Result=" + result + ", SequenceID=" + sequenceID);
            }
            catch (Exception ex)
            {
                _logger.WLOGD(ex.Message);
            }
        }

        private void btnSearchCalendar_Click(object sender, EventArgs e)
        {
            int year = monthCalendar.SelectionStart.Year;
            int month = monthCalendar.SelectionStart.Month;
            UInt32 sequenceID = 0;

            try
            {
                uint result = ssmSdkWrapper.SearchCalendar(
                _deviceUuid,
                _cameraUuid,
                year.ToString(),
                month.ToString(),
                ref sequenceID);
                _logger.WLOGD("SearchCalendar()::Result=" + result + ", SequenceID=" + sequenceID);
            }
            catch (Exception ex)
            {
                _logger.WLOGD(ex.Message);
            }
        }

        private void btnSearchTrackID_Click(object sender, EventArgs e)
        {
            var startDate = monthCalendar.SelectionStart.Date;
            var endDate = monthCalendar.SelectionEnd.Date.AddHours(23.59);
            string startTime = startDate.ToLocalTime().ToString(UtcFormat);
            string endTime = endDate.ToLocalTime().ToString(UtcFormat);
            UInt32 sequenceID = 0;

            try
            {
                uint result = ssmSdkWrapper.SearchTrackID(
                _deviceUuid,
                startTime,
                endTime,
                ref sequenceID);
                _logger.WLOGD("SearchCalendar()::Result=" + result + ", SequenceID=" + sequenceID);
            }
            catch (Exception ex)
            {
                _logger.WLOGD(ex.Message);
            }
        }

        private void btnSearchDay_Click(object sender, EventArgs e)
        {
            Int32 trackId = 0;

            if (!Int32.TryParse(this.txtTrackID.Text, out trackId))
            {
                _logger.WLOGD("SearchDay()::Fail=Check track ID.");
                return;
            }

            var startDate = monthCalendar.SelectionStart.Date;
            var endDate = monthCalendar.SelectionEnd.Date.AddHours(23.59);
            string startTime = startDate.ToLocalTime().ToString(UtcFormat);
            string endTime = endDate.ToLocalTime().ToString(UtcFormat);
            UInt32 sequenceID = 0;

            try
            {
                uint result = ssmSdkWrapper.SearchDay(
                                _deviceUuid,
                                _cameraUuid,
                                trackId,
                                startTime,
                                false,      // DST
                                endTime,
                                false,      // DST
                                (uint)RecordType.ALL,
                                (uint)IVEventType.ALL,
                                ref sequenceID);
                _logger.WLOGD("SearchDay()::Result=" + result + ", SequenceID=" + sequenceID);
            }
            catch (Exception ex)
            {
                _logger.WLOGD(ex.Message);
            }
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
                    else if (device.Type.CompareTo("Camera") == 0)
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

        private void clearLog_Click(object sender, EventArgs e)
        {
            _logger.ClearLog();
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

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
        }
    }
}