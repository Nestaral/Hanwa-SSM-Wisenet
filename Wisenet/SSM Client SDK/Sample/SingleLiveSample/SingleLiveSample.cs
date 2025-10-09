using Newtonsoft.Json;
using SampleLogLib;
using SdkWrapper;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LiveSample
{
    public partial class SingleLiveSample : Form
    {
        enum CommandID { GetRtspUrl = 10003, }
        enum EventID { Login = 11, LogOut = 12, ObjectConnected = 101, ObjectUpdated = 104 }
        enum Mode { Display = 0, Relay = 1, }
        enum MediaType { Live = 1, Playback = 2, }

        private string _rtspUrl;
        private string _cameraUuid, _cameraName;
        private List<ObjectInfo> _cameraList, _deviceList;
        private DebugLog _logger;
        private SsmSdkWrapper ssmSdkWrapper = null;
        private UInt32 mediaId = 0;
        private bool islogin = false;

        public SingleLiveSample()
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
                _rtspUrl = info;
                UpdateRtspUrl();
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
                UpdateComboCameras();
            }
            else if (eventID == (uint)EventID.LogOut)
            {
                islogin = false;
            }
            else if (eventID == (uint)EventID.ObjectUpdated ||
                eventID == (uint)EventID.ObjectConnected)
            {
                UpdateObjectList(info);
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

        private void LiveSample_Load(object sender, EventArgs e)
        {
            ssmSdkWrapper = new SsmSdkWrapper(this.OnResponse, this.OnEvent, this.OnVideo, this.OnAudio);
            ssmSdkWrapper.InitializeEvent();

            ssmSdkWrapper.InitializeMedia(pictureBox1.Handle, 1, ref this.mediaId);
            ssmSdkWrapper.MoveWindow((UInt32)this.mediaId, 0, 0, pictureBox1.Width, pictureBox1.Height);
        }

        private void LiveSample_Closing(object sender, FormClosingEventArgs e)
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

        void SetObjectList(string message)
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
        private void UpdateObjectList(string message)
        {
            try
            {
                dynamic deserialized = JsonConvert.DeserializeObject(message);
                string objects = Convert.ToString(deserialized["Objects"]);
                var objectList = JsonConvert.DeserializeObject<List<ObjectInfo>>(objects);
                foreach (var device in objectList)
                {

                }
            }
            catch (Exception ex)
            {
                _logger.WLOGD(ex.Message);
            }
        }

        private void UpdateRtspUrl()
        {
            try
            {
                txtRtspUrl.Invoke(new MethodInvoker(
                    delegate ()
                    {
                        txtRtspUrl.Text = _rtspUrl;
                        txtRtspUrl.Update();
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

        private void btnGetRtspUrl_Click(object sender, EventArgs e)
        {
            UInt32 sequenceID = 0;
            uint resCode = ssmSdkWrapper.GetRtspUrl(_cameraUuid, 2, 2, 1, ref sequenceID);  // MEDIUM, LIVE, TCP
            _logger.WLOGD("GetRtspUrl()::Result=" + resCode + ", SequenceID=" + sequenceID);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var timeZoneInfo = ssmSdkWrapper.GetTimeZoneInfo(_cameraUuid);
            ssmSdkWrapper.MediaOpen(
                this.mediaId,
                txtRtspUrl.Text,
                txtID.Text,
                txtPassword.Text,
                _cameraName,
                (uint)MediaType.Live,
                "0",                    // start-time
                timeZoneInfo,
                false);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ssmSdkWrapper.MediaClose(this.mediaId);
        }

        private void cbxCameras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCameras.SelectedIndex < 0)
                return;

            var selected = cbxCameras.SelectedItem as ObjectInfo;
            _cameraUuid = selected.Guid;
            _cameraName = selected.Name;
        }

        private void btnSetSoundOn_Click(object sender, EventArgs e)
        {
            ssmSdkWrapper.SetSound((UInt32)this.mediaId, true);
        }

        private void btnSetSoundOff_Click(object sender, EventArgs e)
        {
            ssmSdkWrapper.SetSound((UInt32)this.mediaId, false);
        }

        private void clearLog_Click(object sender, EventArgs e)
        {
            _logger.ClearLog();
        }

        private void btnSetVolume_Click(object sender, EventArgs e)
        {
            ssmSdkWrapper.SetVolume((UInt32)this.mediaId, Convert.ToUInt32(txtVolume.Text));
        }

        private void btnGetVolume_Click(object sender, EventArgs e)
        {
            uint volume = ssmSdkWrapper.GetVolume((UInt32)this.mediaId);
            txtVolume.Invoke(new MethodInvoker(
                    delegate ()
                    {
                        txtVolume.Text = volume.ToString();
                        txtVolume.Update();
                    }));
        }
    }
}