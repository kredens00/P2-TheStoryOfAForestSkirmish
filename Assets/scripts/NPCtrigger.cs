using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCtrigger : MonoBehaviour
{
    private GameObject triggeringNpc;
    private bool triggering;

    public GameObject npcText;
    public GameObject npcText2;


    void Update()
    {
        if(triggering)
        { 

            if (Input.GetKeyUp(KeyCode.E))
           {
                npcText.SetActive(false);
                npcText2.SetActive(true);
           }
        
        }
    }

    private void OnTriggerEnter(Collider other)
    {
       if(other.tag == "Player")
        {
            triggering = true;
            triggeringNpc = other.gameObject;
            npcText.SetActive(true);
        }

    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            triggering = false;
            triggeringNpc = null;
            npcText.SetActive(false);
            npcText2.SetActive(false);
        }
    }
}

