#ifndef _SSMEVENTSDKCLIB_H_
#define _SSMEVENTSDKCLIB_H_

#if defined(_MSC_VER) && (_MSC_VER >= 1200)
# pragma once
#endif

/**
* @file	SsmEventSdkCLib.h
* @brief SsmEventSdk API header file
*/

// The following ifdef block is the standard way of creating macros which make exporting 
// from a DLL simpler. All files within this DLL are compiled with the XNS_EXPORTS
// symbol defined on the command line. this symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see 
// XNS_API functions as being imported from a DLL, wheras this DLL sees symbols
// defined with this macro as being exported.
#ifdef SSMEVENTSDKCLIB_EXPORTS
#define SSME_API __declspec(dllexport)
#else
#define SSME_API __declspec(dllimport)
#endif

#include <Windows.h>
#include <types.h>

namespace SsmEventSdkCLib
{
	SSME_API ULONG SSME_Initialize(
		SSME_OnResponse ssmResponse,
		SSME_OnEvent ssmEvent,
		void* context = nullptr);
	SSME_API void SSME_Release();

	// LogIn & LogOut
	SSME_API ULONG SSME_LogIn(
		const char *strID,
		const char *strPassword,
		const char *strAddress,
		ULONG nPort);
	SSME_API ULONG SSME_DdnsLogIn(
		const char *strID,
		const char *strPassword,
		const char *strDdnsId);
	SSME_API ULONG SSME_UrlLogIn(
		const char *strID,
		const char *strPassword,
		const char *strUrl,
		ULONG nPort);

	SSME_API ULONG SSME_LogIn_Lite(
		const char *strID,
		const char *strPassword,
		const char *strAddress,
		ULONG nPort,
		const char *strCameraUuid);
	SSME_API ULONG SSME_DdnsLogIn_Lite(
		const char *strID,
		const char *strPassword,
		const char *strDdnsId,
		const char *strCameraUuid);
	SSME_API ULONG SSME_UrlLogIn_Lite(
		const char *strID,
		const char *strPassword,
		const char *strUrl,
		ULONG nPort,
		const char *strCameraUuid);

	SSME_API ULONG SSME_LogOut();

	// PTZ Control
	SSME_API ULONG SSME_ControlPTZ(
		const char *strCameraUuid,
		ULONG nAction,
		USHORT nSpeed);
	SSME_API ULONG SSME_GetPresetList(const char *strCameraUuid, ULONG *pSequenceID);
	SSME_API ULONG SSME_AddPreset(
		const char *strCameraUuid,
		ULONG nIndex,
		const char *strName,
		ULONG *pSequenceID);
	SSME_API ULONG SSME_RunPreset(const char *strCameraUuid, ULONG nIndex, ULONG *pSequenceID);

	// Recording Search
	SSME_API ULONG SSME_GetSearchAuthority(
		const char *strDeviceUuid,
		const char *strMultiPasswords,
		ULONG *pSequenceID);
	SSME_API ULONG SSME_ReleaseSearchAuthority(const char *strDeviceUuid, ULONG *pSequenceID);
	SSME_API ULONG SSME_SearchTrackID(
		const char *strDeviceUuid,
		const char *strStartTime,
		const char *strEndTime,
		ULONG *pSequenceID);
	SSME_API ULONG SSME_SearchCalendar(
		const char *strDeviceUuid,
		const char *strCameraUuid,
		const char *strYear,
		const char *strMonth,
		ULONG *pSequenceID);
	SSME_API ULONG SSME_SearchDay(
		const char *strDeviceUuid,
		const char *strCameraUuid,
		long nTrackID,
		const char *strStartTime,
		bool bStartTimeDST,
		const char *strEndTime,
		bool bEndTimeDST,
		ULONG nRecordType,
		ULONG nIVEventType,
		ULONG *pSequenceID);

	// Backup
	SSME_API ULONG SSME_StartBackup(
		const char *strCameraUuid,
		long nTrackID,
		const char *strStartTime,
		bool bStartTimeDST,
		const char *strEndTime,
		bool bEndTimeDST,
		ULONG nFileType,
		const char *strFilePath,
		ULONG nFileSizeLimit,
		ULONG nTimePeriodLimit,
		ULONG *pMediaID,
		ULONG *pSequenceID,
		ULONG nProfileType);
	SSME_API ULONG SSME_StopBackup(const char *strCameraUuid, ULONG nMediaID, ULONG *pSequenceID);

	// Audio
	SSME_API ULONG SSME_StartTalk(
		const char *strDeviceUuid,
		const char *strCameraUuid,
		ULONG *nMediaID,
		ULONG *nProfileID,
		ULONG *pSequenceID);
	SSME_API ULONG SSME_StopTalk(
		const char *strDeviceUuid,
		const char *strCameraUuid,
		ULONG nMediaID,
		ULONG nProfileID,
		ULONG *pSequenceID);
	SSME_API ULONG SSME_SendTalk(
		const char *strDeviceUuid,
		const char *strCameraUuid,
		ULONG nMediaID,
		ULONG nProfileID,
		ULONG nAudioSize,
		long *pAudioData);

	// System
	SSME_API char* SSME_GetUserInfo();
	SSME_API ULONG SSME_InsertExternalLog(
		const char *strDeviceUuid,
		const char *strCameraUuid,
		ULONG nEventID,
		ULONG *pSequenceID);
	SSME_API ULONG SSME_InsertExternalLogEventKey(
		const char *strDeviceUuid,
		const char *strCameraUuid,
		ULONG nEventKey,
		ULONG *pSequenceID);
	SSME_API ULONG SSME_InsertExternalANPREventKey(
		const char *strDeviceUuid,
		const char *strCameraUuid,
		ULONG nEventKey,
		wchar_t *strEventMsg,
		ULONG *pSequenceID);
	SSME_API ULONG SSME_ChangePassword(
		const char *strUserID,
		const char *strCurrentPassword,
		const char *strNewPassword,
		ULONG *pSequenceID);
	SSME_API ULONG SSME_GetRtspUrl(
		const char *strCameraUuid,
		ULONG nProfileType,
		ULONG nStreamType,
		ULONG nProtocolType,
		ULONG *pSequenceID);
	SSME_API char* SSME_GetTimeZoneInfo(const char *strDeviceUuid);
	SSME_API ULONG SSME_GetFirmwareVersion(const char *strCameraUuid);

	SSME_API char* SSME_GetUserGroupInfo();
	SSME_API ULONG SSME_AddUser(const char *json, ULONG *pSequenceID);
	SSME_API ULONG SSME_ModifyUser(const char *json, ULONG *pSequenceID);
	SSME_API ULONG SSME_DeleteUser(const char *json, ULONG *pSequenceID);
	SSME_API ULONG SSME_AddUserGroup(const char *json, ULONG *pSequenceID);
	SSME_API ULONG SSME_ModifyUserGroup(const char *json, ULONG *pSequenceID);
	SSME_API ULONG SSME_DeleteUserGroup(const char *json, ULONG *pSequenceID);

	SSME_API ULONG SSME_GetNtp(ULONG *pSequenceID);
	SSME_API ULONG SSME_SetNtp(const char *json, ULONG *pSequenceID);

	SSME_API ULONG SSME_GetSnapshot(const char *json, ULONG *pSequenceID);

	SSME_API ULONG SSME_StartLiveLocalRecording(const char *json, ULONG *pSequenceID);
	SSME_API ULONG SSME_StopLiveLocalRecording(const char *json, ULONG *pSequenceID);
	SSME_API ULONG SSME_StartDeviceRecording(const char *cameraGuid, ULONG *pSequenceID);
	SSME_API ULONG SSME_StopDeviceRecording(const char *cameraGuid, ULONG *pSequenceID);
	SSME_API char* SSME_GetObjectList();
	SSME_API char* SSME_GetObject(const char *objectGuid);
}		//  SsmEventSdkCLib

#endif	// SSMEVENTSDKCLIB_H_