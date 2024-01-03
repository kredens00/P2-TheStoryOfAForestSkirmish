using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerOff : MonoBehaviour
{
    PlayerController player;
    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.FindObjectOfType<PlayerController>();

    }

    // Update is called once per frame
    public void SetControllerOff()
    {
        player.enabled = false;
    }

    public void SetControllerOn()
    {
        player.enabled = true;
    }
}
