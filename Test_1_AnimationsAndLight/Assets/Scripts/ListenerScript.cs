using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListenerScript : MonoBehaviour
{
    private SpeakerScript speakerScript;

    private void Awake()
    {
        speakerScript = FindObjectOfType<SpeakerScript>();
    }

    public void Listen()
    {
        Debug.Log("Message recived:[" + PlayerPrefs.GetString("MessageKey") + "]");
    }
}
