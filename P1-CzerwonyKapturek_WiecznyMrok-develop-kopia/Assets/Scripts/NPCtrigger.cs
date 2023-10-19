using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CleverCrow.Fluid.QuestJournals.Quests;
using CleverCrow.Fluid.QuestJournals.Utilities;

public class NPCtrigger : MonoBehaviour
{
   
    private GameObject triggeringNpc;
    private bool triggering;
    private bool ePressed;
    public GameObject npcText;
    public GameObject npcText2;
    public GameObject npcText3;
    public QuestUpdater _questUpdater;
    public IQuestInstance _questInstance;
    
    void Update()
    {
        if (triggering)
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                if (!ePressed)
                {
                    npcText.SetActive(false);
                    npcText2.SetActive(true);
                    ePressed = true;
                }
                else if(npcText3 != null)
                {
                    npcText2.SetActive(false);
                    npcText3.SetActive(true);
                    _questUpdater.NextTask();
                    
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            triggering = true;
            triggeringNpc = other.gameObject;
            npcText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            triggering = false;
            triggeringNpc = null;
            npcText.SetActive(false);
            npcText3.SetActive(false);
            npcText2.SetActive(false);
            ePressed = false;
        }
    }
}