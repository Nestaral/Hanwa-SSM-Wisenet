/******************************************************************************
* ==++==
* Copyright (c) 2019 Hanwha Techwin, Inc. All rights reserved.
*
* This software is copyrighted by, and is the sole property of Hanwha Techwin.
* All rigths, title, ownership, or other interests in the software remain the
* property of Hanwha Techwin. This software may only be used in accordance with
* the corresponding license agreement. Any unauthorized use, duplication,
* transmission, distribution, or disclosure of this software is expressly
* forbidden.
*
* This Copyright notice may not be removed or modified without prior written
* consent of Hanwha Techwin.
*
* Hanwha Techwin reserves the right to modify this software without notice.
*
* Hanwha Techwin, Inc.
* http://www.hanwhatechwin.com
* ==--==
******************************************************************************/
#include "stdafx.h"
#include "SsmSdkWrapper.h"
#include <string>
using namespace std;


#pragma comment(lib, "SsmEventSdkCLib.lib")
#pragma comment(lib, "SsmMediaSdkCLib.lib")

using namespace SdkWrapper;
using namespace SsmEventSdkCLib;
using namespace SsmMediaSdkCLib;

SsmSdkWrapper::SsmSdkWrapper(Dele_OnResponse_^ deleOnResponse, Dele_OnEvent_^ deleOnEvent)
{
	this->deleOnResponse = deleOnResponse;
	this->deleOnEvent = deleOnEvent;
	this->deleOnVideo = nullptr;
	this->deleOnAudio = nullptr;

	OnResponseSink = gcnew Dele_OnResponse(this, &SsmSdkWrapper::OnResponse);
	OnEventSink = gcnew Dele_OnEvent(this, &SsmSdkWrapper::OnEvent);

	OnEventFromMediaSink = gcnew Dele_OnEventFromMedia(this, &SsmSdkWrapper::OnEventFromMedia);
	OnVideoSink = gcnew Dele_OnVideo(this, &SsmSdkWrapper::OnVideo);
	OnAudioSink = gcnew Dele_OnAudio(this, &SsmSdkWrapper::OnAudio);
}

SsmSdkWrapper::SsmSdkWrapper(Dele_OnResponse_^ deleOnResponse, Dele_OnEvent_^ deleOnEvent, Dele_OnVideo_^ deleOnVideo, Dele_OnAudio_^ deleOnAudio)
{
	this->deleOnResponse = deleOnResponse;
	this->deleOnEvent = deleOnEvent;
	this->deleOnVideo = deleOnVideo;
	this->deleOnAudio = deleOnAudio;

	OnResponseSink = gcnew Dele_OnResponse(this, &SsmSdkWrapper::OnResponse);
	OnEventSink = gcnew Dele_OnEvent(this, &SsmSdkWrapper::OnEvent);

	OnEventFromMediaSink = gcnew Dele_OnEventFromMedia(this, &SsmSdkWrapper::OnEventFromMedia);
	OnVideoSink = gcnew Dele_OnVideo(this, &SsmSdkWrapper::OnVideo);
	OnAudioSink = gcnew Dele_OnAudio(this, &SsmSdkWrapper::OnAudio);
}

SsmSdkWrapper::~SsmSdkWrapper()
{
	SSMM_Finalize();
}

void SsmSdkWrapper::OnResponse(
	unsigned long nCommandID,
	unsigned long nErrorCode,
	unsigned long nSequenceID,
	char *strInfo,
	void *context)
{
	if (this->deleOnResponse != nullptr)
	{
		String^ info = String::Empty;
		ConvertCharToString(strInfo, info);

		this->deleOnResponse(nCommandID, nErrorCode, nSequenceID, info);
	}
}

void SsmSdkWrapper::OnEvent(
	unsigned long nEventID,
	char *strInfo,
	void *context)
{
	if (this->deleOnEvent != nullptr)
	{
		String^ info = String::Empty;
		ConvertCharToString(strInfo, info);

		this->deleOnEvent(nEventID, info);
	}
}

void SsmSdkWrapper::OnEventFromMedia(
	unsigned long nEventID,
	void *context)
{
}

Int32 SsmSdkWrapper::OnVideo(
	unsigned long nMediaID,
	unsigned long nCodecType,
	unsigned short nFrameType,
	unsigned short nSequence,
	char *strRecTime,
	unsigned long nUtcTime,
	bool bDST,
	unsigned long nTimeStamp,
	unsigned long nWidth,
	unsigned long nHeight,
	unsigned long nVideoSize,
	unsigned char *pVideo,
	void *context)
{
	if (this->deleOnVideo != nullptr)
	{
		String^ recTime = String::Empty;
		ConvertCharToString(strRecTime, recTime);

		cli::array<Byte>^ videoData = gcnew cli::array<Byte>(nVideoSize);
		Marshal::Copy((IntPtr)((char*)pVideo), videoData, 0, nVideoSize);

		this->deleOnVideo(nMediaID, nCodecType, nFrameType, nSequence, recTime, nUtcTime, bDST, nTimeStamp, nWidth, nHeight, nVideoSize, videoData);
	}

	return 0;
}

Int32 SsmSdkWrapper::OnAudio(
	unsigned long nMediaID,
	unsigned long nCodecType,
	unsigned long nTimeStamp,
	long nBitPerSample,
	long nBitrate,
	long nChannel,
	long nSampleRate,
	unsigned long nAudioSize,
	unsigned char *pAudio,
	void *context)
{
	if (this->deleOnAudio != nullptr)
	{
		cli::array<Byte>^ audioData = gcnew cli::array<Byte>(nAudioSize);
		Marshal::Copy((IntPtr)((char*)pAudio), audioData, 0, nAudioSize);

		this->deleOnAudio(nMediaID, nCodecType, nTimeStamp, nBitPerSample, nBitrate,
			nChannel, nSampleRate, nAudioSize, audioData);
	}

	return 0;
}

void SsmSdkWrapper::InitializeEvent()
{
	IntPtr pOnResponse = Marshal::GetFunctionPointerForDelegate(OnResponseSink);
	IntPtr pOnEvent = Marshal::GetFunctionPointerForDelegate(OnEventSink);

	ULONG retEventInitalize = SSME_Initialize(
		static_cast<void(__stdcall *)(unsigned long nCommandID, unsigned long nErrorCode, unsigned long nSequenceID, char *strInfo, void *context)>(pOnResponse.ToPointer()),
		static_cast<void(__stdcall *)(unsigned long nEventID, char *strInfo, void *context)>(pOnEvent.ToPointer()),
		nullptr);
}

void SsmSdkWrapper::InitializeMedia(IntPtr tileHandle, Int32 mediaMode, UInt32% mediaID)
{
	IntPtr pOnEventFromMedia = Marshal::GetFunctionPointerForDelegate(OnEventFromMediaSink);
	IntPtr pOnVideo = Marshal::GetFunctionPointerForDelegate(OnVideoSink);
	IntPtr pOnAudio = Marshal::GetFunctionPointerForDelegate(OnAudioSink);

	ULONG mid = 0;

	ULONG retMediaInitalize = SSMM_Initialize(mediaMode, tileHandle.ToPointer(),
		static_cast<void(__stdcall *)(unsigned long nEventID, void *context)>(pOnEventFromMedia.ToPointer()),
		static_cast<void(__stdcall *)(unsigned long nMediaID, unsigned long nCodecType, unsigned short nFrameType, unsigned short nSequence, char *strRecTime,
			unsigned long nUtcTime, bool bDST, unsigned long nTimeStamp, unsigned long nWidth, unsigned long nHeight,
			unsigned long nVideoSize, unsigned char *pVideo, void *context)>(pOnVideo.ToPointer()),
		static_cast<void(__stdcall *)(unsigned long nMediaID, unsigned long nCodecType, unsigned long nTimeStamp, long nBitPerSample, long nBitrate,
			long nChannel, long nSampleRate, unsigned long nAudioSize, unsigned char *pAudio, void *context)>(pOnAudio.ToPointer()),
		&mid,
		NULL);

	mediaID = mid;
}

void SsmSdkWrapper::ReleaseEvent()
{
	SSME_Release();
}

void SsmSdkWrapper::ReleaseMedia(UInt64 mediaID)
{
	SSMM_Release(mediaID);
}

UInt32 SsmSdkWrapper::Login(String^ strId, String^ strPassword, String^ strIpAddress, UInt32 port)
{
	char id[64] = "";
	char password[64] = "";
	char ipAddress[18] = "";

	cli::pin_ptr<const System::Char> pChar = PtrToStringChars(strId);
	const wchar_t *psz = pChar;

	ConvertStringToChar(strId, id, sizeof(id));
	ConvertStringToChar(strPassword, password, sizeof(password));
	ConvertStringToChar(strIpAddress, ipAddress, sizeof(ipAddress));

	UInt32 ret = SSME_LogIn(id, password, ipAddress, port);

	return ret;
}

UInt32 SsmSdkWrapper::DdnsLogin(String^ strId, String^ strPassword, String^ strDdnsID)
{
	char id[64] = "";
	char password[64] = "";
	char ddnsId[64] = "";

	ConvertStringToChar(strId, id, sizeof(id));
	ConvertStringToChar(strPassword, password, sizeof(password));
	ConvertStringToChar(strDdnsID, ddnsId, sizeof(ddnsId));

	UInt32 ret = SSME_DdnsLogIn(id, password, ddnsId);

	return ret;
}

UInt32 SsmSdkWrapper::UrlLogin(String^ strId, String^ strPassword, String^ strUrl, UInt32 port)
{
	char id[64] = "";
	char password[64] = "";
	char url[200] = "";

	ConvertStringToChar(strId, id, sizeof(id));
	ConvertStringToChar(strPassword, password, sizeof(password));
	ConvertStringToChar(strUrl, url, sizeof(url));

	UInt32 ret = SSME_UrlLogIn(id, password, url, port);

	return ret;
}

UInt32 SsmSdkWrapper::Login_Lite(String^ strId, String^ strPassword, String^ strIpAddress, UInt32 port, String^ cameraUid)
{
	char id[64] = "";
	char password[64] = "";
	char ipAddress[18] = "";
	char guid[40] = "";

	ConvertStringToChar(strId, id, sizeof(id));
	ConvertStringToChar(strPassword, password, sizeof(password));
	ConvertStringToChar(strIpAddress, ipAddress, sizeof(ipAddress));
	ConvertStringToChar(cameraUid, guid, sizeof(guid));

	UInt32 ret = SSME_LogIn_Lite(id, password, ipAddress, port, guid);

	return ret;
}

UInt32 SsmSdkWrapper::DdnsLogin_Lite(String^ strId, String^ strPassword, String^ strDdnsID, String^ cameraUid)
{
	char id[64] = "";
	char password[64] = "";
	char ddnsId[64] = "";
	char guid[40] = "";

	ConvertStringToChar(strId, id, sizeof(id));
	ConvertStringToChar(strPassword, password, sizeof(password));
	ConvertStringToChar(strDdnsID, ddnsId, sizeof(ddnsId));
	ConvertStringToChar(cameraUid, guid, sizeof(guid));

	UInt32 ret = SSME_DdnsLogIn_Lite(id, password, ddnsId, guid);

	return ret;
}

UInt32 SsmSdkWrapper::UrlLogin_Lite(String^ strId, String^ strPassword, String^ strUrl, UInt32 port, String^ cameraUid)
{
	char id[64] = "";
	char password[64] = "";
	char url[200] = "";
	char guid[40] = "";

	ConvertStringToChar(strId, id, sizeof(id));
	ConvertStringToChar(strPassword, password, sizeof(password));
	ConvertStringToChar(strUrl, url, sizeof(url));
	ConvertStringToChar(cameraUid, guid, sizeof(guid));

	UInt32 ret = SSME_UrlLogIn_Lite(id, password, url, port, guid);

	return ret;
}

UInt32 SsmSdkWrapper::Logout()
{
	UInt32 ret = SSME_LogOut();

	return ret;
}

String^ SsmSdkWrapper::GetObjectList()
{
	char* objectList = SSME_GetObjectList();

	String^ json = String::Empty;
	ConvertCharToString(objectList, json);

	return json;
}

String^ SsmSdkWrapper::GetObject(String^ objectGuid)
{
	char guid[40] = "";

	ConvertStringToChar(objectGuid, guid, sizeof(guid));

	char* objectList = SSME_GetObject(guid);

	String^ json = String::Empty;
	ConvertCharToString(objectList, json);

	return json;
}

UInt32 SsmSdkWrapper::ControlPTZ(String^ cameraUuid, UInt32 action, UInt16 speed)
{
	char cameraId[40] = "";

	ConvertStringToChar(cameraUuid, cameraId, sizeof(cameraId));

	UInt32 ret = SSME_ControlPTZ(cameraId, action, speed);

	return ret;
}

UInt32 SsmSdkWrapper::GetPresetList(String^ cameraUuid, UInt32% sequenceID)
{
	char cameraId[40] = "";
	ULONG seqId = 0;

	ConvertStringToChar(cameraUuid, cameraId, sizeof(cameraId));

	UInt32 ret = SSME_GetPresetList(cameraId, &seqId);

	sequenceID = seqId;

	return ret;
}

UInt32 SsmSdkWrapper::AddPreset(String^ cameraUuid, UInt32 index, String^ name, UInt32% sequenceID)
{
	char cameraId[40] = "";
	char presetName[100] = "";
	ULONG seqId = 0;

	ConvertStringToChar(cameraUuid, cameraId, sizeof(cameraId));
	ConvertStringToChar(name, presetName, sizeof(presetName));

	UInt32 ret = SSME_AddPreset(cameraId, index, presetName, &seqId);

	sequenceID = seqId;

	return ret;
}

UInt32 SsmSdkWrapper::RunPreset(String^ cameraUuid, UInt32 index, UInt32% sequenceID)
{
	char cameraId[40] = "";
	ULONG seqId = 0;

	ConvertStringToChar(cameraUuid, cameraId, sizeof(cameraId));

	UInt32 ret = SSME_RunPreset(cameraId, index, &seqId);

	sequenceID = seqId;

	return ret;
}

// Recording Search
UInt32 SsmSdkWrapper::GetSearchAuthority(String^ deviceUuid, String^ multiPasswords, UInt32% sequenceID)
{
	char deviceId[40] = "";
	char password[60] = "";
	ULONG seqId = 0;

	ConvertStringToChar(deviceUuid, deviceId, sizeof(deviceId));
	ConvertStringToChar(multiPasswords, password, sizeof(password));

	UInt32 ret = SSME_GetSearchAuthority(deviceId, password, &seqId);

	sequenceID = seqId;

	return ret;
}

UInt32 SsmSdkWrapper::ReleaseSearchAuthority(String^ deviceUuid, UInt32% sequenceID)
{
	char deviceId[40] = "";
	ULONG seqId = 0;

	ConvertStringToChar(deviceUuid, deviceId, sizeof(deviceId));

	UInt32 ret = SSME_ReleaseSearchAuthority(deviceId, &seqId);

	sequenceID = seqId;

	return ret;
}

UInt32 SsmSdkWrapper::SearchTrackID(String^ deviceUuid, String^ startTime, String^ endTime, UInt32% sequenceID)
{
	char deviceId[40] = "";
	char start[40] = "";
	char end[40] = "";
	ULONG seqId = 0;

	ConvertStringToChar(deviceUuid, deviceId, sizeof(deviceId));
	ConvertStringToChar(startTime, start, sizeof(start));
	ConvertStringToChar(endTime, end, sizeof(end));

	UInt32 ret = SSME_SearchTrackID(deviceId, start, end, &seqId);

	sequenceID = seqId;

	return ret;
}

UInt32 SsmSdkWrapper::SearchCalendar(String^ deviceUuid, String^ cameraUuid, String^ year, String^ month, UInt32% sequenceID)
{
	char deviceId[40] = "";
	char cameraId[40] = "";
	char yearString[5] = "";
	char monthString[3] = "";
	ULONG seqId = 0;

	ConvertStringToChar(deviceUuid, deviceId, sizeof(deviceId));
	ConvertStringToChar(cameraUuid, cameraId, sizeof(cameraId));
	ConvertStringToChar(year, yearString, sizeof(yearString));
	ConvertStringToChar(month, monthString, sizeof(monthString));

	UInt32 ret = SSME_SearchCalendar(deviceId, cameraId, yearString, monthString, &seqId);

	sequenceID = seqId;

	return ret;
}

UInt32 SsmSdkWrapper::SearchDay(String^ deviceUuid, String^ cameraUuid, Int32 trackID, String^ startTime, Boolean startTimeDST,
	String^ endTime, Boolean endTimeDST, UInt32 recordType, UInt32 IVEventType, UInt32% sequenceID)
{
	char deviceId[40] = "";
	char cameraId[40] = "";
	char start[40] = "";
	char end[40] = "";
	ULONG seqId = 0;

	ConvertStringToChar(deviceUuid, deviceId, sizeof(deviceId));
	ConvertStringToChar(cameraUuid, cameraId, sizeof(cameraId));
	ConvertStringToChar(startTime, start, sizeof(start));
	ConvertStringToChar(endTime, end, sizeof(end));

	UInt32 ret = SSME_SearchDay(deviceId, cameraId, trackID, start, startTimeDST, end, endTimeDST, recordType, IVEventType, &seqId);

	sequenceID = seqId;

	return ret;
}

// Backup
UInt32 SsmSdkWrapper::StartBackup(String^ cameraUuid, Int32 trackID, String^ startTime, Boolean startTimeDST, String^ endTime,
	bool endTimeDST, UInt32 fileType, String^ filePath, UInt32 fileSizeLimit, UInt32 timePeriodLimit, UInt32% mediaID, UInt32% sequenceID, UInt32 profileType)
{
	char cameraId[40] = "";
	char start[40] = "";
	char end[40] = "";
	char path[1000] = "";
	ULONG mediaId = 0;
	ULONG seqId = 0;

	ConvertStringToChar(cameraUuid, cameraId, sizeof(cameraId));
	ConvertStringToChar(startTime, start, sizeof(start));
	ConvertStringToChar(endTime, end, sizeof(end));
	ConvertStringToChar(filePath, path, sizeof(path));

	UInt32 ret = SSME_StartBackup(cameraId, trackID, start, startTimeDST, end, endTimeDST, fileType, path, fileSizeLimit, timePeriodLimit, &mediaId, &seqId, profileType);

	mediaID = mediaId;
	sequenceID = seqId;

	return ret;
}

UInt32 SsmSdkWrapper::StopBackup(String^ cameraUuid, UInt32 mediaID, UInt32% sequenceID)
{
	char cameraId[40] = "";
	ULONG seqId = 0;

	ConvertStringToChar(cameraUuid, cameraId, sizeof(cameraId));

	UInt32 ret = SSME_StopBackup(cameraId, mediaID, &seqId);

	sequenceID = seqId;

	return ret;
}

// Audio
UInt32 SsmSdkWrapper::StartTalk(String^ deviceUuid, String^ cameraUuid, UInt32% mediaID, UInt32% profileID, UInt32% sequenceID)
{
	char deviceId[40] = "";
	char cameraId[40] = "";

	ULONG mediaId = 0;
	ULONG profile = 0;
	ULONG seqId = 0;

	ConvertStringToChar(deviceUuid, deviceId, sizeof(deviceId));
	ConvertStringToChar(cameraUuid, cameraId, sizeof(cameraId));

	UInt32 ret = SSME_StartTalk(deviceId, cameraId, &mediaId, &profile, &seqId);

	mediaID = mediaId;
	profileID = profile;
	sequenceID = seqId;

	return ret;
}

UInt32 SsmSdkWrapper::StopTalk(String^ deviceUuid, String^ cameraUuid, UInt32 mediaID, UInt32 profileID, UInt32% sequenceID)
{
	char deviceId[40] = "";
	char cameraId[40] = "";
	ULONG seqId = 0;

	ConvertStringToChar(deviceUuid, deviceId, sizeof(deviceId));
	ConvertStringToChar(cameraUuid, cameraId, sizeof(cameraId));

	UInt32 ret = SSME_StopTalk(deviceId, cameraId, mediaID, profileID, &seqId);

	sequenceID = seqId;

	return ret;
}

UInt32 SsmSdkWrapper::SendTalk(String^ deviceUuid, String^ cameraUuid, UInt32 mediaID, UInt32 profileID, UInt32 audioSize, cli::array<Byte>^ audioData)
{
	char deviceId[40] = "";
	char cameraId[40] = "";
	ULONG seqId = 0;

	ConvertStringToChar(deviceUuid, deviceId, sizeof(deviceId));
	ConvertStringToChar(cameraUuid, cameraId, sizeof(cameraId));

	IntPtr audioPtr = Marshal::AllocHGlobal(audioData->Length);
	Marshal::Copy(audioData, 0, audioPtr, audioData->Length);

	UInt32 ret = SSME_SendTalk(deviceId, cameraId, mediaID, profileID, audioSize, (long*)audioPtr.ToPointer());
	Marshal::FreeHGlobal(audioPtr);

	return ret;
}

// System
String^ SsmSdkWrapper::GetUserInfo()
{
	char* userInfo = SSME_GetUserInfo();

	String^ json = String::Empty;
	ConvertCharToString(userInfo, json);

	return json;
}

UInt32 SsmSdkWrapper::InsertExternalLog(String^ deviceUuid, String^ cameraUuid, UInt32 eventID, UInt32% sequenceID)
{
	char deviceId[40] = "";
	char cameraId[40] = "";
	ULONG seqId = 0;

	ConvertStringToChar(deviceUuid, deviceId, sizeof(deviceId));
	ConvertStringToChar(cameraUuid, cameraId, sizeof(cameraId));

	UInt32 ret = SSME_InsertExternalLog(deviceId, cameraId, eventID, &seqId);

	sequenceID = seqId;

	return ret;
}

UInt32 SsmSdkWrapper::InsertExternalLogEventKey(String^ deviceUuid, String^ cameraUuid, UInt32 eventKey, UInt32% sequenceID)
{
	char deviceId[40] = "";
	char cameraId[40] = "";
	ULONG seqId = 0;

	ConvertStringToChar(deviceUuid, deviceId, sizeof(deviceId));
	ConvertStringToChar(cameraUuid, cameraId, sizeof(cameraId));

	UInt32 ret = SSME_InsertExternalLogEventKey(deviceId, cameraId, eventKey, &seqId);

	sequenceID = seqId;

	return ret;
}

UInt32 SsmSdkWrapper::InsertExternalANPREventKey(String^ deviceUuid, String^ cameraUuid, UInt32 eventKey, String^ eventMsg, UInt32% sequenceID)
{
	char deviceId[40] = "";
	char cameraId[40] = "";

	ULONG seqId = 0;

	ConvertStringToChar(deviceUuid, deviceId, sizeof(deviceId));
	ConvertStringToChar(cameraUuid, cameraId, sizeof(cameraId));

	wchar_t* chars = (wchar_t*)(Marshal::StringToHGlobalUni(eventMsg)).ToPointer();
	wstring logMsg = chars;

	string msg = "";
	msg.assign(logMsg.begin(), logMsg.end());

	UInt32 ret = SSME_InsertExternalANPREventKey(deviceId, cameraId, eventKey, chars, &seqId);
	
	sequenceID = seqId;

	return ret;
}

UInt32 SsmSdkWrapper::ChangePassword(String^ userID, String^ currentPassword, String^ newPassword, UInt32% sequenceID)
{
	IntPtr userIDPtr = Marshal::StringToHGlobalAnsi(userID);
	IntPtr currentPasswordPtr = Marshal::StringToHGlobalAnsi(currentPassword);
	IntPtr newPasswordPtr = Marshal::StringToHGlobalAnsi(newPassword);
	ULONG seqId = 0;

	UInt32 ret = SSME_ChangePassword((char*)userIDPtr.ToPointer(), (char*)currentPasswordPtr.ToPointer(), (char*)newPasswordPtr.ToPointer(), &seqId);

	sequenceID = seqId;

	Marshal::FreeHGlobal(userIDPtr);
	Marshal::FreeHGlobal(currentPasswordPtr);
	Marshal::FreeHGlobal(newPasswordPtr);

	return ret;
}

UInt32 SsmSdkWrapper::GetRtspUrl(String^ cameraUuid, UInt32 profileType, UInt32 streamType, UInt32 protocolType, UInt32% sequenceID)
{
	char guid[40] = "";
	ULONG seqId = 0;

	ConvertStringToChar(cameraUuid, guid, sizeof(guid));

	UInt32 ret = SSME_GetRtspUrl(guid, profileType, streamType, protocolType, &seqId);

	sequenceID = seqId;

	return ret;
}

String^ SsmSdkWrapper::GetTimeZoneInfo(String^ cameraGuid)
{
	char guid[40] = "";
	ConvertStringToChar(cameraGuid, guid, sizeof(guid));

	char* timeZoneInfo = SSME_GetTimeZoneInfo(guid);

	String^ strTimeZone = String::Empty;
	ConvertCharToString(timeZoneInfo, strTimeZone);

	return strTimeZone;
}

UInt32 SsmSdkWrapper::GetFirmwareVersion(String^ cameraUuid)
{
	char guid[40] = "";

	ConvertStringToChar(cameraUuid, guid, sizeof(guid));

	UInt32 ret = SSME_GetFirmwareVersion(guid);

	return ret;
}

String^ SsmSdkWrapper::GetUserGroupInfo()
{
	char* userGroupInfo = SSME_GetUserGroupInfo();

	String^ json = String::Empty;
	ConvertCharToString(userGroupInfo, json);

	return json;
}

UInt32 SsmSdkWrapper::AddUser(String^ json, UInt32% sequenceID)
{
	IntPtr jsonPtr = Marshal::StringToHGlobalAnsi(json);
	ULONG seqId = 0;

	UInt32 ret = SSME_AddUser((char*)jsonPtr.ToPointer(), &seqId);

	sequenceID = seqId;

	Marshal::FreeHGlobal(jsonPtr);

	return ret;
}

UInt32 SsmSdkWrapper::ModifyUser(String^ json, UInt32% sequenceID)
{
	IntPtr jsonPtr = Marshal::StringToHGlobalAnsi(json);
	ULONG seqId = 0;

	UInt32 ret = SSME_ModifyUser((char*)jsonPtr.ToPointer(), &seqId);

	sequenceID = seqId;

	Marshal::FreeHGlobal(jsonPtr);

	return ret;
}

UInt32 SsmSdkWrapper::DeleteUser(String^ json, UInt32% sequenceID)
{
	IntPtr jsonPtr = Marshal::StringToHGlobalAnsi(json);
	ULONG seqId = 0;

	UInt32 ret = SSME_DeleteUser((char*)jsonPtr.ToPointer(), &seqId);

	sequenceID = seqId;

	Marshal::FreeHGlobal(jsonPtr);

	return ret;
}

UInt32 SsmSdkWrapper::AddUserGroup(String^ json, UInt32% sequenceID)
{
	IntPtr jsonPtr = Marshal::StringToHGlobalAnsi(json);
	ULONG seqId = 0;

	UInt32 ret = SSME_AddUserGroup((char*)jsonPtr.ToPointer(), &seqId);

	sequenceID = seqId;

	Marshal::FreeHGlobal(jsonPtr);

	return ret;
}

UInt32 SsmSdkWrapper::ModifyUserGroup(String^ json, UInt32% sequenceID)
{
	IntPtr jsonPtr = Marshal::StringToHGlobalAnsi(json);
	ULONG seqId = 0;

	UInt32 ret = SSME_ModifyUserGroup((char*)jsonPtr.ToPointer(), &seqId);

	sequenceID = seqId;

	Marshal::FreeHGlobal(jsonPtr);

	return ret;
}

UInt32 SsmSdkWrapper::DeleteUserGroup(String^ json, UInt32% sequenceID)
{
	IntPtr jsonPtr = Marshal::StringToHGlobalAnsi(json);
	ULONG seqId = 0;

	UInt32 ret = SSME_DeleteUserGroup((char*)jsonPtr.ToPointer(), &seqId);

	sequenceID = seqId;

	Marshal::FreeHGlobal(jsonPtr);

	return ret;
}

UInt32 SsmSdkWrapper::GetNtp(UInt32% sequenceID)
{
	ULONG seqId = 0;

	UInt32 ret = SSME_GetNtp(&seqId);

	sequenceID = seqId;

	return ret;
}

UInt32 SsmSdkWrapper::SetNtp(String^ json, UInt32% sequenceID)
{
	IntPtr jsonPtr = Marshal::StringToHGlobalAnsi(json);
	ULONG seqId = 0;

	UInt32 ret = SSME_SetNtp((char*)jsonPtr.ToPointer(), &seqId);

	sequenceID = seqId;

	Marshal::FreeHGlobal(jsonPtr);

	return ret;
}

UInt32 SsmSdkWrapper::GetSnapshot(String^ json, UInt32% sequenceID)
{
	IntPtr jsonPtr = Marshal::StringToHGlobalAnsi(json);
	ULONG seqId = 0;

	UInt32 ret = SSME_GetSnapshot((char*)jsonPtr.ToPointer(), &seqId);

	sequenceID = seqId;

	Marshal::FreeHGlobal(jsonPtr);

	return ret;

}

UInt32 SsmSdkWrapper::StartLiveLocalRecording(String^ json, UInt32% sequenceID)
{
	IntPtr jsonPtr = Marshal::StringToHGlobalAnsi(json);
	ULONG seqId = 0;

	UInt32 ret = SSME_StartLiveLocalRecording((char*)jsonPtr.ToPointer(), &seqId);

	sequenceID = seqId;

	Marshal::FreeHGlobal(jsonPtr);

	return ret;
}

UInt32 SsmSdkWrapper::StopLiveLocalRecording(String^ json, UInt32% sequenceID)
{
	IntPtr jsonPtr = Marshal::StringToHGlobalAnsi(json);
	ULONG seqId = 0;

	UInt32 ret = SSME_StopLiveLocalRecording((char*)jsonPtr.ToPointer(), &seqId);

	sequenceID = seqId;

	Marshal::FreeHGlobal(jsonPtr);

	return ret;
}

UInt32 SsmSdkWrapper::StartDeviceRecording(String^ cameraGuid, UInt32% sequenceID)
{
	char guid[40] = "";
	ULONG seqId = 0;

	ConvertStringToChar(cameraGuid, guid, sizeof(guid));

	UInt32 ret = SSME_StartDeviceRecording(guid, &seqId);

	sequenceID = seqId;

	return ret;
}

UInt32 SsmSdkWrapper::StopDeviceRecording(String^ cameraGuid, UInt32% sequenceID)
{
	char guid[40] = "";
	ULONG seqId = 0;

	ConvertStringToChar(cameraGuid, guid, sizeof(guid));

	UInt32 ret = SSME_StopDeviceRecording(guid, &seqId);

	sequenceID = seqId;

	return ret;
}

void SsmSdkWrapper::MediaOpen(UInt32 mediaID, String^ strRTSPUrl, String^ strID, String^ strPassword, String^ strCameraName, UInt32 nMediaType,
	String^ strStartTime, String^ strTimeZoneInfo, Boolean bStartTimeDST)
{
	char rtspUrl[100] = "";
	char id[64] = "";
	char password[64] = "";
	char cameraName[64] = "";
	char startTime[25] = "";
	char timeZone[10000] = "";

	ConvertStringToChar(strRTSPUrl, rtspUrl, sizeof(rtspUrl));
	ConvertStringToChar(strID, id, sizeof(id));
	ConvertStringToChar(strPassword, password, sizeof(password));
	ConvertStringToChar(strCameraName, cameraName, sizeof(cameraName));
	ConvertStringToChar(strStartTime, startTime, sizeof(startTime));
	ConvertStringToChar(strTimeZoneInfo, timeZone, sizeof(timeZone));

	SSMM_Open(mediaID, rtspUrl, id, password, cameraName, nMediaType, startTime, timeZone, bStartTimeDST);
}

void SsmSdkWrapper::MediaClose(UInt32 mediaID)
{
	SSMM_Close(mediaID);
}

void SsmSdkWrapper::Play(UInt32 mediaID, double dbSpeed)
{
	SSMM_Play(mediaID, dbSpeed);
}

void SsmSdkWrapper::Pause(UInt32 mediaID)
{
	SSMM_Pause(mediaID);
}

void SsmSdkWrapper::Seek(UInt32 mediaID, String^ time, Boolean timeDST)
{
	IntPtr timePtr = Marshal::StringToHGlobalAnsi(time);

	SSMM_Seek(mediaID, (char*)timePtr.ToPointer(), timeDST);

	Marshal::FreeHGlobal(timePtr);
}

void SsmSdkWrapper::FrameAdvance(UInt32 mediaID, Int32 delta)
{
	SSMM_FrameAdvance(mediaID, delta);
}

// Display Control
void SsmSdkWrapper::MoveWindow(UInt32 mediaID, Int32 x, Int32 y, Int32 width, Int32 height)
{
	try
	{
		SSMM_MoveWindow(mediaID, x, y, width, height);
	}
	catch (Exception^ e)
	{
		System::Diagnostics::Trace::WriteLine("[EXCEPTION] SsmSdkWrapper::MoveWindows : " + e->Message);
	}
}

// Audio Control
void SsmSdkWrapper::SetSound(UInt32 mediaID, Boolean on)
{
	SSMM_SetSound(mediaID, on);
}

void SsmSdkWrapper::SetVolume(UInt32 mediaID, UInt32 volume)
{
	SSMM_SetVolume(mediaID, volume);
}

UInt32 SsmSdkWrapper::GetVolume(UInt32 mediaID)
{
	return SSMM_GetVolume(mediaID);
}

// Snapshot	
void SsmSdkWrapper::SaveSnapshot(UInt32 mediaID, String^ fileName)
{
	IntPtr fileNamePtr = Marshal::StringToHGlobalAnsi(fileName);

	SSMM_SaveSnapshot(mediaID, (char*)fileNamePtr.ToPointer());

	Marshal::FreeHGlobal(fileNamePtr);
}