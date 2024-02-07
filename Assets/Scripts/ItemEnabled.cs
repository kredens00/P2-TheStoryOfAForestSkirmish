using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CleverCrow.Fluid.QuestJournals.Quests;
using CleverCrow.Fluid.QuestJournals;

public class ItemEnabled : MonoBehaviour
{
    public IQuestInstance _questInstance;
    public QuestDefinitionBase quest;
    public GameObject Item;

    // Start is called before the first frame update
    void Start()
    {
        _questInstance = QuestJournalManager.Instance.Quests.Get(quest);
        if (_questInstance != null && _questInstance.Status == QuestStatus.Ongoing)
        {
            Item.SetActive(true);

        }

    }

}
