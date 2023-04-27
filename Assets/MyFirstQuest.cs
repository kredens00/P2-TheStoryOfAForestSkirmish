using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CleverCrow.Fluid.QuestJournals;

public class MyFirstQuest : MonoBehaviour
{
    private IQuestInstance _questInstance;
    public QuestDefinitionBase quest;

    void Start()
    {
        _questInstance = QuestJournalManager.Instance.Quests.Add(quest);

        // Prints Ongoing
        Debug.Log(_questInstance.Status);
    }

    public void NextTask()
    {
        _questInstance.Next();

        // Prints the current task name
        Debug.Log(_questInstace.ActiveTask.Title);
    }
}