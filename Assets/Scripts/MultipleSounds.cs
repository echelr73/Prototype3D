using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleSounds : MonoBehaviour
{
    public AudioClip audioClip1;
    public AudioClip audioClip2;
    public AudioClip audioClip3;

    public void playSound1()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip1;
        audioSource.volume = 0.2f;
        audioSource.Play();
    }

    public void playSound2()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip2;
        audioSource.volume= 1.0f;
        audioSource.Play();
    }

    public void playSound3()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip3;
        audioSource.volume = 1.0f;
        audioSource.Play();
    }
}
