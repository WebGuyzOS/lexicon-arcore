// Copyright (c) 2018 Mixspace Technologies, LLC. All rights reserved.

using UnityEngine;
using GoogleARCore;

namespace Mixspace.Lexicon.Samples
{
    public class AndroidPermissions : MonoBehaviour
    {
        void Awake()
        {
            const string microphonePermissionName = "android.permission.RECORD_AUDIO";
            AndroidPermissionsManager.RequestPermission(microphonePermissionName).ThenAction((grantResult) =>
            {
                if (grantResult.IsAllGranted)
                {
                    if (LexiconRuntime.CurrentRuntime != null)
                    {
                        LexiconRuntime.CurrentRuntime.Restart();
                    }
                }
                else
                {
                    Debug.LogError("Lexicon requires microphone permissions");
                }
            });
        }
    }
}
