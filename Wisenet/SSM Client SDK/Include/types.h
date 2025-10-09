#ifndef TYPES_H_
#define TYPES_H_

typedef void(__stdcall *SSME_OnResponse)(
	unsigned long nCommandID, 
	unsigned long nErrorCode, 
	unsigned long nSequenceID,
	char *strInfo,
	void *context);
typedef void(__stdcall *SSME_OnEvent)(
	unsigned long nEventID, 
	char *strInfo,
	void *context);

typedef void(__stdcall *SSMM_OnEvent)(
	unsigned long nEventID, 
	void *context);
typedef void(__stdcall *SSMM_OnVideo)(
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
	void *context);
typedef void(__stdcall *SSMM_OnAudio)(
	unsigned long nMediaID,
	unsigned long nCodecType,
	unsigned long nTimeStamp,
	long nBitPerSample,
	long nBitrate,
	long nChannel,
	long nSampleRate,
	unsigned long nAudioSize,
	unsigned char *pAudio,
	void *context);

#endif	// TYPES_H_