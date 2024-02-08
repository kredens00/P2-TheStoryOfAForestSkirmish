using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CleverCrow.Fluid.QuestJournals.Quests;
using CleverCrow.Fluid.QuestJournals;

public class Ricky : MonoBehaviour
{

    public IQuestInstance _questInstance;
    public QuestDefinitionBase quest;
    public GameObject active;
    public GameObject inactive;
    //public string talked;
    // Start is called before the first frame update
    void Start()
    {
       

            _questInstance = QuestJournalManager.Instance.Quests.Get(quest);
            if (_questInstance != null && _questInstance.Status == QuestStatus.Ongoing)
            {
                if (active != null)
                {

                    active.SetActive(true);
                    inactive.SetActive(false);
                    //PlayerPrefs.SetInt(talked, 1);
                }
               

            }
        }

       
    

   
}
