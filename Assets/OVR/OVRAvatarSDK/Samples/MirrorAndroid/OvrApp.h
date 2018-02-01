/************************************************************************************

Filename    :   OvrApp.h
Content     :   Trivial use of the application framework.
Created     :
Authors     :

Copyright   :   Copyright 2014 Oculus VR, LLC. All Rights reserved.

************************************************************************************/

#ifndef OVRAPP_H
#define OVRAPP_H

#include "App.h"
#include "SceneView.h"
#include "SoundEffectContext.h"
#include "GuiSys.h"
#include "VrApi_Input.h"

#include "AvatarManager.h"

namespace OVR {
	class ovrLocale;
}

namespace OvrTemplateApp
{

class OvrApp : public OVR::VrAppInterface
{
public:
							OvrApp();
	virtual					~OvrApp();

	virtual void 			Configure( OVR::ovrSettings & settings );
	virtual void			EnteredVrMode( const OVR::ovrIntentType intentType, const char * intentFromPackage, const char * intentJSON, const char * intentURI );
	virtual void			LeavingVrMode();
	virtual bool 			OnKeyEvent( const int keyCode, const int repeatCount, const OVR::KeyEventType eventType );
	virtual OVR::ovrFrameResult Frame( const OVR::ovrFrameInput & vrFrame );

	class OVR::ovrLocale &	GetLocale() { return *Locale; }

private:
	void OnMalibuConnected();
	void EnumerateInputDevices();
	void UpdateMalibuController( const OVR::ovrFrameInput & vrFrame );

	OVR::ovrSoundEffectContext * SoundEffectContext;
	OVR::OvrGuiSys::SoundEffectPlayer * SoundEffectPlayer;
	OVR::OvrGuiSys *		GuiSys;
	OVR::ovrLocale *		Locale;

	ovrFrameParms			FrameParms;

	OVR::ModelFile *		SceneModel;
	OVR::OvrSceneView		Scene;

	OVR::AvatarManager		TheAvatarManager;

	ovrDeviceID				MalibuDeviceID = ovrDeviceIdType_Invalid;
	ovrInputTrackedRemoteCapabilities RemoteCapabilities;
};

} // namespace OvrTemplateApp

#endif	// OVRAPP_H
