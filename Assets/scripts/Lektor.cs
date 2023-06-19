using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Lektor : MonoBehaviour
{
    public AudioClip audioClip;
    public string audioID;
    public bool onAwake;

    private AudioSource audioSource;

   
    void Start()
    {
        if (PlayerPrefs.HasKey(audioID))
        {
            Destroy(gameObject);
        } else
        {
            audioSource = GetComponent<AudioSource>();
            if(onAwake) {
                PlayAudio();
            }
            
        }
        
        
    }

    public void PlayAudio()
    {
        audioSource.clip = audioClip;
        audioSource.Play();
        SaveAudio();
    }

    private void SaveAudio()
    {
        
        {
            PlayerPrefs.SetInt(audioID, 1);
            PlayerPrefs.Save();
        }


    }
}
