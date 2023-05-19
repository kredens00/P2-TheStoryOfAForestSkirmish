using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lektor : MonoBehaviour
{
    public AudioClip audioClip;

    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    public void PlayAudio()
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }
}
