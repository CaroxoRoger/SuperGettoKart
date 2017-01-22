using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MuteUnmuteButton : MonoBehaviour {
    AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    public void Mute_Unmute(bool button)
    {
        if (button == true)
        {
            audio.mute = true;
        }
        else
        {
            audio.mute = false;
        }
    }
}
