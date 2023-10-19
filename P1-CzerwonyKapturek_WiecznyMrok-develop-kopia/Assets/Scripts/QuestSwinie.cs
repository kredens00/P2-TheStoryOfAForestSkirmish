using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CleverCrow.Fluid.QuestJournals.Quests;
using CleverCrow.Fluid.QuestJournals.Utilities;

public class QuestSwinie : MonoBehaviour
{

    private GameObject triggeringNpc;
    private bool triggering;
    private bool ePressed;
    
    public QuestUpdater _questUpdater;
    public IQuestInstance _questInstance;
    public GameObject npcText;

    void Start()
    {

         
    }

    // Update is called once per frame
    void Update()
    {

        bool ifPicked = GameObject.Find("³om");
        if (!ifPicked)
        {
            
            _questUpdater.NextTask();
            npcText.SetActive(true);
            GameObject.Find("Brak_przejscia").SetActive(false);
            GameObject.Find("przejscie_kladka").SetActive(true);

        }
        
    }
   
}
