using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 사운드 : MonoBehaviour
{
    public AudioSource musicsource;
    public AudioSource btnsource;
    public void SetMusicVolume(float volume)
    {
        musicsource.volume = volume;
    }

    public void SetButtonVolume(float volume)
    {
        btnsource.volume = volume;
    }

    public void On효과음()
    {
        btnsource.Play();
    }
}
