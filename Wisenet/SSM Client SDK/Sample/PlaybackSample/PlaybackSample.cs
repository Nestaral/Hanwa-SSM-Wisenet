using Newtonsoft.Json;
using SampleLogLib;
using SdkWrapper;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PlaybackSample
{
    public partial class PlaybackSample : Form
    {
        enum CommandID { GetRtspUrl = 10003, }
        enum EventID {
            Login = 11,
            LogOut = 12,
        }
        enum Mode { Display = 0, Relay = 1, }
        enum MediaType { Live = 1, Playback = 2, }

        private string _timeZoneInfo;
        private string _deviceUuid, _deviceName;
        private string _cameraUuid, _cameraName;
        private List<ObjectInfo> _cameraList, _deviceList;
        private DebugLog _logger;
        private SsmSdkWrapper ssmSdkWrapper = null;
        private UInt32 mediaId = 0;
        private bool islogin = false;

        public PlaybackSample()
        {
            InitializeComponent();
            _logger = new DebugLog(txtStatus);
            _cameraList = new List<ObjectInfo>();
            _deviceList = new List<ObjectInfo>();
        }

        private void OnResponse(UInt32 commandID, UInt32 errorCode, UInt32 sequenceID, string info)
        {
            _logger.WLOGD(
             "OnResponse()::" +
             " Command ID=" + commandID +
             " Result=" + errorCode +
             " Sequence ID= " + sequenceID +
             " Info=" + info);

            if (commandID == (uint)CommandID.GetRtspUrl)
            {
                UpdateUrl(info);
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
                SetObjectList(info);
                UpdateComboDevices();
                UpdateComboCameras();
            }
            else if (eventID == (uint)EventID.LogOut)
            {
                islogin = false;
            }
        }

        public void OnVideo(UInt32 mediaID, UInt32 codecType, UInt16 frameType, UInt16 sequence, String recTime,
            UInt32 utcTime, Boolean useDst, UInt32 timeStamp, UInt32 width, UInt32 height, UInt32 videoSize, byte[] videoData)
        {
            String videoLog = DateTime.Now.ToString("hh:mm:ss.fff") + " " + String.Format("Video MediaID : {0}, CodecType : {1}, FrameType : {2}, Sequence : {3}, RecTime : {4}, UtcTime : {5}, UseDst : {6}, TimeStamp : {7}, Width : {8}, Height : {9}, VideoSize : {10}",
                mediaID, codecType, frameType, sequence, recTime, utcTime, useDst, timeStamp, width, height, videoSize);

            System.Diagnostics.Trace.WriteLine(videoLog);
        }

        public void OnAudio(UInt32 mediaID, UInt32 codecType, UInt32 timeStamp, Int32 bitPerSample, Int32 bitrate,
            Int32 channel, Int32 sampleRate, UInt32 audioSize, byte[] audioData)
        {
            String audioLog = DateTime.Now.ToString("hh:mm:ss.fff") + " " + String.Format("Audio MediaID : {0}, CodecType : {1}, TimeStamp : {2}, BitPerSample : {3}, Bitrate : {4}, Channel : {5}, SampleRate : {6}, audioSize : {7}", mediaID, codecType, timeStamp, bitPerSample, bitrate, channel, sampleRate, audioSize);

            System.Diagnostics.Trace.WriteLine(audioLog);
        }

        private void PlaybackSample_Load(object sender, EventArgs e)
        {
            ssmSdkWrapper = new SsmSdkWrapper(this.OnResponse, this.OnEvent, this.OnVideo, this.OnAudio);
            ssmSdkWrapper.InitializeEvent();

            ssmSdkWrapper.InitializeMedia(pictureBox1.Handle, 0, ref this.mediaId);
            //ssmSdkWrapper.InitializeMedia(pictureBox1.Handle, 1, ref this.mediaId); // forward
            //ssmSdkWrapper.InitializeMedia(pictureBox1.Handle, 2, ref this.mediaId); // forward-decoded

            ssmSdkWrapper.MoveWindow((UInt32)this.mediaId, 0, 0, pictureBox1.Width, pictureBox1.Height);
        }

        private void PlaybackSample_Closing(object sender, FormClosingEventArgs e)
        {
            ssmSdkWrapper.MediaClose(this.mediaId);
            ssmSdkWrapper.ReleaseMedia(this.mediaId);

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

        private void btnGetRtspUrl_Click(object sender, EventArgs e)
        {
            UInt32 sequenceID = 0;
            uint resCode = ssmSdkWrapper.GetRtspUrl(_cameraUuid, 1, 4, 1, ref sequenceID);
            _logger.WLOGD("GetRtspUrl()::Result=" + resCode + ", SequenceID=" + sequenceID);
        }

        private void btnGetTimeZone_Click(object sender, EventArgs e)
        {
            _timeZoneInfo = ssmSdkWrapper.GetTimeZoneInfo(_deviceUuid);
            _logger.WLOGD("GetTimeZoneInfo()::Result=" + _timeZoneInfo);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (_timeZoneInfo == null)
                _timeZoneInfo = ssmSdkWrapper.GetTimeZoneInfo(_deviceUuid);

            ssmSdkWrapper.MediaOpen(
                this.mediaId,
                txtRtspUrl.Text,
                txtID.Text,
                txtPassword.Text,
                _cameraName,
                (uint)MediaType.Playback,
                txtStartTime.Text,    // start-time
                _timeZoneInfo,
                false);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            ssmSdkWrapper.Pause((UInt32)this.mediaId);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            ssmSdkWrapper.Play((UInt32)this.mediaId, Convert.ToDouble(txtSpeed.Text));
        }

        private void btnSeek_Click(object sender, EventArgs e)
        {
            ssmSdkWrapper.Seek((UInt32)this.mediaId, txtSeekTime.Text, false);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ssmSdkWrapper.MediaClose((UInt32)this.mediaId);
        }

        private void btnGetPrevFrame_Click(object sender, EventArgs e)
        {
            ssmSdkWrapper.FrameAdvance((UInt32)this.mediaId, -1);
        }

        private void btnGetNextFrame_Click(object sender, EventArgs e)
        {
            ssmSdkWrapper.FrameAdvance((UInt32)this.mediaId, 1);
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

        private void clearLog_Click(object sender, EventArgs e)
        {
            _logger.ClearLog();
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

        private void UpdateUrl(string rstpUrl)
        {
            try
            {
                txtRtspUrl.Invoke(new MethodInvoker(
                    delegate ()
                    {
                        txtRtspUrl.Text = rstpUrl;
                        txtRtspUrl.Update();
                    }));
            }
            catch (Exception ex)
            {
                _logger.WLOGD(ex.Message);
            }
        }

        private void btnSaveSnapshot_Click(object sender, EventArgs e)
        {
            string fileName = "MySnapshot";
            ssmSdkWrapper.SaveSnapshot((UInt32)this.mediaId, fileName);
        }
    }
}