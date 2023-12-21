using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class SpeakerScript : MonoBehaviour
{
    private ListenerScript listenerScript;

    private void Awake()
    {
        listenerScript = FindObjectOfType<ListenerScript>();
        PlayerPrefs.SetString("MessageKey", "secret");
    }

    public void SpeakOnClick()
    {
        listenerScript.Listen();
    }
}
