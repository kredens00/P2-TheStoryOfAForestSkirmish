using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class camera_confiner : MonoBehaviour
{
    // Start is called before the first frame update

    
    public CinemachineConfiner confiner;


    void Start()
    {
        



    }

    // Update is called once per frame
    void Update()
    {
        confiner.InvalidatePathCache();
        confiner.m_BoundingShape2D = GameObject.FindGameObjectWithTag("Confiner").GetComponent<Collider2D>();
    }
}
