using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_delay : MonoBehaviour
{

    public float delayBetweenLoops = 5f;
    private float timer = 0f;
    public static Music_delay instance;


    void Update()
    {
        
        if (!GetComponent<AudioSource>().isPlaying)
        {
            
            timer += Time.deltaTime;

            
            if (timer >= delayBetweenLoops)
            {
                GetComponent<AudioSource>().Play();
                timer = 0f; 
            }
        }
    }

    void Awake()
    {
        if (!instance)
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
            
        }
        else
        {

            Destroy(gameObject);
        }
    }

}
