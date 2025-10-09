// SsmSdkWrapper.h
#include "SsmEventSdkCLib.h"
#include "SsmMediaSdkCLib.h"

#include <vcclr.h>
#pragma once

using namespace System;
using namespace System::Text;
using namespace System::Runtime::InteropServices;

namespace SdkWrapper {

	enum
	{
		Mode_Display = 0,
		Mode_Forward = 1,
		Mode_RGB32 = 2,

		MediaType_Live = 1,
		MediaType_Playback = 2,
	};

	public delegate void Dele_OnResponse(unsigned long nCommandID, unsigned long nErrorCode, unsigned long nSequenceID, char *strInfo, void *context);
	public delegate void Dele_OnEvent(unsigned long nEventID, char *strInfo, void *context);
	public delegate void Dele_OnEventFromMedia(unsigned long nEventID, void *context);
	public delegate Int32 Dele_OnVideo(unsigned long nMediaID, unsigned long nCodecType, unsigned short nFrameType, unsigned short nSequence, char *strRecTime,
		unsigned long nUtcTime, bool bDST, unsigned long nTimeStamp, unsigned long nWidth, unsigned long nHeight,
		unsigned long nVideoSize, unsigned char *pVideo, void *context);
	public delegate Int32 Dele_OnAudio(unsigned long nMediaID, unsigned long nCodecType, unsigned long nTimeStamp, long nBitPerSample, long nBitrate,
		long nChannel, long nSampleRate, unsigned long nAudioSize, unsigned char *pAudio, void *context);

	public delegate void Dele_OnResponse_(UInt32 nCommandID, UInt32 nErrorCode, UInt32 nSequenceID, String^ strInfo);
	public delegate void Dele_OnEvent_(UInt32 nEventID, String^ strInfo);
	public delegate void Dele_OnVideo_(UInt32 nMediaID, UInt32 nCodecType, UInt16 nFrameType, UInt16 nSequence, String^ strRecTime,
		UInt32 nUtcTime, Boolean bDST, UInt32 nTimeStamp, UInt32 nWidth, UInt32 nHeight,
		UInt32 nVideoSize, cli::array<Byte>^ videoData);
	public delegate void Dele_OnAudio_(UInt32 nMediaID, UInt32 nCodecType, UInt32 nTimeStamp, Int32 nBitPerSample, Int32 nBitrate,
		Int32 nChannel, Int32 nSampleRate, UInt32 nAudioSize, cli::array<Byte>^ audioData);

	public ref class SsmSdkWrapper
	{
	public:
		SsmSdkWrapper(Dele_OnResponse_^ deleOnResponse, Dele_OnEvent_^ deleOnEvent);
		SsmSdkWrapper(Dele_OnResponse_^ deleOnResponse, Dele_OnEvent_^ deleOnEvent, Dele_OnVideo_^ deleOnVideo, Dele_OnAudio_^ deleOnAudio);
		~SsmSdkWrapper();

		void InitializeEvent();
		void ReleaseEvent();

		void InitializeMedia(IntPtr tileHandle, Int32 mediaMode, UInt32% mediaID);
		void ReleaseMedia(UInt64 mediaID);

		// Login
		UInt32 Login(String^ id, String^ password, String^ ipAddress, UInt32 port);
		UInt32 DdnsLogin(String^ id, String^ password, String^ ddnsID);
		UInt32 UrlLogin(String^ id, String^ password, String^ url, UInt32 port);

		// Login lite
		UInt32 Login_Lite(String^ id, String^ password, String^ ipAddress, UInt32 port, String^ cameraUid);
		UInt32 DdnsLogin_Lite(String^ id, String^ password, String^ ddnsID, String^ cameraUid);
		UInt32 UrlLogin_Lite(String^ id, String^ password, String^ url, UInt32 port, String^ cameraUid);

		// Logout
		UInt32 Logout();

		// PTZ Control
		UInt32 ControlPTZ(String^ cameraUuid, UInt32 action, UInt16 speed);
		UInt32 GetPresetList(String^ cameraUuid, UInt32% sequenceID);
		UInt32 AddPreset(String^ cameraUuid, UInt32 index, String^ name, UInt32% sequenceID);
		UInt32 RunPreset(String^ cameraUuid, UInt32 index, UInt32% sequenceID);

		// Recording Search
		UInt32 GetSearchAuthority(String^ deviceUuid, String^ multiPasswords, UInt32% sequenceID);
		UInt32 ReleaseSearchAuthority(String^ deviceUuid, UInt32% sequenceID);
		UInt32 SearchTrackID(String^ deviceUuid, String^ startTime, String^ endTime, UInt32% sequenceID);
		UInt32 SearchCalendar(String^ deviceUuid, String^ cameraUuid, String^ year, String^ month, UInt32% sequenceID);
		UInt32 SearchDay(String^ deviceUuid, String^ cameraUuid, Int32 trackID, String^ startTime, Boolean startTimeDST,
			String^ endTime, Boolean endTimeDST, UInt32 recordType, UInt32 IVEventType, UInt32% sequenceID);

		// Backup
		UInt32 StartBackup(String^ cameraUuid, Int32 trackID, String^ startTime, Boolean startTimeDST, String^ endTime,
			bool endTimeDST, UInt32 fileType, String^ filePath, UInt32 fileSizeLimit, UInt32 timePeriodLimit,
			UInt32% mediaID, UInt32% sequenceID, UInt32 profileType);
		UInt32 StopBackup(String^ cameraUuid, UInt32 mediaID, UInt32% sequenceID);

		// Audio
		UInt32 StartTalk(String^ deviceUuid, String^ cameraUuid, UInt32% mediaID, UInt32% profileID, UInt32% sequenceID);
		UInt32 StopTalk(String^ deviceUuid, String^ cameraUuid, UInt32 mediaID, UInt32 profileID, UInt32% sequenceID);
		UInt32 SendTalk(String^ deviceUuid, String^ cameraUuid, UInt32 mediaID, UInt32 profileID, UInt32 audioSize, cli::array<Byte>^ audioData);

		// System
		String^ GetUserInfo();
		UInt32 InsertExternalLog(String^ deviceUuid, String^ cameraUuid, UInt32 eventID, UInt32% sequenceID);
		UInt32 InsertExternalLogEventKey(String^ deviceUuid, String^ cameraUuid, UInt32 eventKey, UInt32% sequenceID);
		UInt32 InsertExternalANPREventKey(String^ deviceUuid, String^ cameraUuid, UInt32 eventKey, String^ eventMsg, UInt32% sequenceID);
		UInt32 ChangePassword(String^ userID, String^ currentPassword, String^ newPassword, UInt32% sequenceID);
		UInt32 GetRtspUrl(String^ cameraUuid, UInt32 profileType, UInt32 streamType, UInt32 protocolType, UInt32% sequenceID);
		String^ GetTimeZoneInfo(String^ cameraGuid);
		UInt32 GetFirmwareVersion(String^ cameraUuid);

		String^ GetUserGroupInfo();
		UInt32 AddUser(String^ json, UInt32% sequenceID);
		UInt32 ModifyUser(String^ json, UInt32% sequenceID);
		UInt32 DeleteUser(String^ json, UInt32% sequenceID);
		UInt32 AddUserGroup(String^ json, UInt32% sequenceID);
		UInt32 ModifyUserGroup(String^ json, UInt32% sequenceID);
		UInt32 DeleteUserGroup(String^ json, UInt32% sequenceID);

		UInt32 GetNtp(UInt32% sequenceID);
		UInt32 SetNtp(String^ json, UInt32% sequenceID);

		UInt32 GetSnapshot(String^ json, UInt32% sequenceID);

		UInt32 StartLiveLocalRecording(String^ json, UInt32% sequenceID);
		UInt32 StopLiveLocalRecording(String^ json, UInt32% sequenceID);
		UInt32 StartDeviceRecording(String^ cameraGuid, UInt32% sequenceID);
		UInt32 StopDeviceRecording(String^ cameraGuid, UInt32% sequenceID);
		String^ GetObjectList();
		String^ GetObject(String^ objectGuid);

		void MediaOpen(UInt32 mediaID, String^ RTSPUrl, String^ id, String^ password, String^ cameraName, UInt32 mediaType,
			String^ startTime, String^ timeZoneInfo, Boolean startTimeDST);
		void MediaClose(UInt32 mediaID);

		void Play(UInt32 mediaID, double dbSpeed);
		void Pause(UInt32 mediaID);
		void Seek(UInt32 mediaID, String^ time, Boolean timeDST);
		void FrameAdvance(UInt32 mediaID, Int32 delta);

		// Display Control
		void MoveWindow(UInt32 mediaID, Int32 x, Int32 y, Int32 width, Int32 height);

		// Audio Control
		void SetSound(UInt32 mediaID, Boolean on);
		void SetVolume(UInt32 mediaID, UInt32 volume);
		UInt32 GetVolume(UInt32 mediaID);

		// Snapshot	
		void SaveSnapshot(UInt32 mediaID, String^ fileName);

		void OnResponse(unsigned long nCommandID, unsigned long nErrorCode, unsigned long nSequenceID, char *strInfo, void *context);
		void OnEvent(unsigned long nEventID, char *strInfo, void *context);
		void OnEventFromMedia(unsigned long nEventID, void *context);
		Int32 OnVideo(unsigned long nMediaID, unsigned long nCodecType, unsigned short nFrameType, unsigned short nSequence, char *strRecTime,
			unsigned long nUtcTime, bool bDST, unsigned long nTimeStamp, unsigned long nWidth, unsigned long nHeight,
			unsigned long nVideoSize, unsigned char *pVideo, void *context);
		Int32 OnAudio(
			unsigned long nMediaID, unsigned long nCodecType, unsigned long nTimeStamp, long nBitPerSample, long nBitrate,
			long nChannel, long nSampleRate, unsigned long nAudioSize, unsigned char *pAudio, void *context);

	protected:
		Dele_OnResponse^		OnResponseSink;
		Dele_OnEvent^			OnEventSink;

		Dele_OnEventFromMedia^	OnEventFromMediaSink;
		Dele_OnVideo^			OnVideoSink;
		Dele_OnAudio^			OnAudioSink;

		Dele_OnResponse_^ deleOnResponse;
		Dele_OnEvent_^ deleOnEvent;
		Dele_OnVideo_^ deleOnVideo;
		Dele_OnAudio_^ deleOnAudio;

	public:
		static void ConvertStringToChar(String^ strSrc, unsigned char* szDest, Int32 length)
		{
			IntPtr szTemp = IntPtr::Zero;
			if (strSrc->Length >= length)
				szTemp = Marshal::StringToHGlobalAnsi(strSrc->Substring(0, length - 1));
			else
				szTemp = Marshal::StringToHGlobalAnsi(strSrc);

			char* fn = (char*)(void*)szTemp;
			int nLen = strlen(fn);

			if (nLen > length - 1)
			{
				memcpy(szDest, fn, length - 1);
				szDest[length - 1] = 0;
			}
			else
			{
				memcpy(szDest, fn, nLen);
				szDest[nLen] = 0;
			}

			Marshal::FreeHGlobal(szTemp);
		}
		static void ConvertStringToChar(String^ strSrc, char* szDest, Int32 length)
		{
			if (strSrc == nullptr)
				return;

			IntPtr szTemp = IntPtr::Zero;
			if (strSrc->Length >= length)
				szTemp = Marshal::StringToHGlobalAnsi(strSrc->Substring(0, length - 1));
			else
				szTemp = Marshal::StringToHGlobalAnsi(strSrc);

			char* charPtrA = (char*)szTemp.ToPointer();
			OutputDebugStringA(charPtrA);

			char* fn = (char*)(void*)szTemp;
			OutputDebugStringA(fn);
			int nLen = strlen(fn);

			String^ convertStringA = gcnew String(charPtrA);

			if (nLen > length - 1)
			{
				memcpy(szDest, fn, length - 1);
				szDest[length - 1] = 0;
			}
			else
			{
				memcpy(szDest, fn, nLen);
				szDest[nLen] = 0;
			}

			Marshal::FreeHGlobal(szTemp);
		}

		static void ConvertCharToString(const char* szSrc, String^ %strDst)
		{
			int			 length = strlen(szSrc) + 1;
			cli::array<Byte>^ aByte = gcnew cli::array<Byte>(length);

			Marshal::Copy((IntPtr)((unsigned char*)szSrc), aByte, 0, length);
			strDst = Encoding::GetEncoding(0)->GetString(aByte, 0, length);

			int index = strDst->IndexOf('\0');
			if (index > -1)
				strDst = strDst->Remove(index);
		}

		static void ConvertCharToString(const char* szSrc, String^ %strDst, Encoding^ encoding)
		{
			int			 length = strlen(szSrc) + 1;
			cli::array<Byte>^ aByte = gcnew cli::array<Byte>(length);

			Marshal::Copy((IntPtr)((unsigned char*)szSrc), aByte, 0, length);
			if (encoding != nullptr)
				strDst = encoding->GetString(aByte, 0, length);
			else
				strDst = Encoding::GetEncoding(0)->GetString(aByte, 0, length);

			int index = strDst->IndexOf('\0');
			if (index > -1)
				strDst = strDst->Remove(index);
		}

		static void ConvertStringToCharPwd(String^ strSrc, char* szDest, Int32 length)
		{
			IntPtr szTemp = IntPtr::Zero;
			if (strSrc->Length > length)
				szTemp = Marshal::StringToHGlobalAnsi(strSrc->Substring(0, length));
			else
				szTemp = Marshal::StringToHGlobalAnsi(strSrc);

			char* fn = (char*)(void*)szTemp;
			int nLen = strlen(fn);

			if (nLen >= length)
			{
				memcpy(szDest, fn, length);
			}
			else
			{
				memcpy(szDest, fn, nLen);
				szDest[nLen] = 0;
			}

			Marshal::FreeHGlobal(szTemp);
		}

		static void ConvertStringToChar(String^ strSrc, char* szDest, Int32 length, char oldChar, char newChar)
		{
			IntPtr szTemp = IntPtr::Zero;
			if (strSrc->Length >= length)
				szTemp = Marshal::StringToHGlobalAnsi(strSrc->Substring(0, length - 1));
			else
				szTemp = Marshal::StringToHGlobalAnsi(strSrc);

			char* fn = (char*)(void*)szTemp;
			int nLen = strlen(fn);

			// replace oldChar to newChar
			for (int i = 0; i < nLen; i++)
			{
				if (fn[i] == oldChar)
					fn[i] = newChar;
			}

			if (nLen > length - 1)
			{
				memcpy(szDest, fn, length - 1);
				szDest[length - 1] = 0;
			}
			else
			{
				memcpy(szDest, fn, nLen);
				szDest[nLen] = 0;
			}

			Marshal::FreeHGlobal(szTemp);
		}
	};
}
