using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainActivation : MonoBehaviour
{

    public ParticleSystem particleSystem;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        if (particleSystem != null)
        {
            particleSystem.Play();
        }
    }
}
