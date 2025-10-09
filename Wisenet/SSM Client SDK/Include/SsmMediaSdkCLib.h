#ifndef _SSMMEDIASDKCLIB_H_
#define _SSMMEDIASDKCLIB_H_

#if defined(_MSC_VER) && (_MSC_VER >= 1200)
# pragma once
#endif

/**
* @file	SsmMediaSdkCLib.h
* @brief SsmMediaSdk API header file
*/


// The following ifdef block is the standard way of creating macros which make exporting 
// from a DLL simpler. All files within this DLL are compiled with the XNS_EXPORTS
// symbol defined on the command line. this symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see 
// XNS_API functions as being imported from a DLL, wheras this DLL sees symbols
// defined with this macro as being exported.
#ifdef SSMMEDIASDKCLIB_EXPORTS
#define SSMM_API __declspec(dllexport)
#else
#define SSMM_API __declspec(dllimport)
#endif

#include <Windows.h>
#include <types.h>

namespace SsmMediaSdkCLib 
{
	// 새로운 Window 객체를 생성합니다. 
	// 객체가 성공적으로 생성되면, nMediaId가 부여됩니다. 
	// 이후 명령들은 nMediaId를 첫 파라미터로 넣고 동작시킵니다.
	SSMM_API ULONG SSMM_Initialize(
		ULONG nMode,
		void *hParentWnd,
		SSMM_OnEvent ssmEvent, 
		SSMM_OnVideo ssmVideo, 
		SSMM_OnAudio ssmAudio,
		ULONG *nMediaId,
		void *context = nullptr);
	SSMM_API void SSMM_Finalize();
	SSMM_API ULONG SSMM_Release(const ULONG nMediaId);
	
	// Video/Audio Streaming 
	SSMM_API void SSMM_Open(
		ULONG nMediaId,
		const char *strRTSPUrl,
		const char *strID,
		const char *strPassword,
		const char *strCameraName,
		ULONG nMediaType, 
		const char *strStartTime,
		const char *strTimeZoneInfo,
		bool bStartTimeDST);
	SSMM_API void SSMM_Close(const ULONG nMediaId);
	SSMM_API void SSMM_Play(const ULONG nMediaId, double dbSpeed);
	SSMM_API void SSMM_Pause(const ULONG nMediaId);
	SSMM_API void SSMM_Seek(const ULONG nMediaId, const char *strTime, bool bTimeDST);
	SSMM_API void SSMM_FrameAdvance(const ULONG nMediaId, long nDelta);
	
	// Display Control
	SSMM_API void SSMM_MoveWindow(const ULONG nMediaId, const int x, int y, int width, int height);

	// Audio Control
	SSMM_API void SSMM_SetSound(const ULONG nMediaId, bool bOn);
	SSMM_API void SSMM_SetVolume(const ULONG nMediaId, ULONG nVolume);
	SSMM_API ULONG SSMM_GetVolume(const ULONG nMediaId);

	// Snapshot	
	SSMM_API void SSMM_SaveSnapshot(const ULONG nMediaId, const char *strFileName);
}


#endif //_SSMMEDIASDKCLIB_H_