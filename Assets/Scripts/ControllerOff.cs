using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerOff : MonoBehaviour
{
    PlayerController player;
    Animator anim;
    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.FindObjectOfType<PlayerController>();
        anim = GameObject.FindObjectOfType<Animator>();

    }

    // Update is called once per frame
    public void SetControllerOff()
    {
        player.enabled = false;
        anim.enabled = false;
        
    }

    public void SetControllerOn()
    {
        player.enabled = true;
        anim.enabled = true;
    }
}
