using UnityEngine;
using CleverCrow.Fluid.QuestJournals;
using CleverCrow.Fluid.QuestJournals.Quests;
using CleverCrow.Fluid.QuestJournals.Examples;

public class QuestUpdater : MonoBehaviour
{
    public IQuestInstance _questInstance;
    public QuestDefinitionBase quest;
    
   

    void Start()
    {
        _questInstance = QuestJournalManager.Instance.Quests.Add(quest);

        // Prints Ongoing
        Debug.Log(_questInstance.Status);
        Debug.Log(_questInstance.ActiveTask.Title);
    }

    public void NextTask()
    {
       _questInstance.Next();
       

        // Prints the current task name
        Debug.Log(_questInstance.Status);
        Debug.Log(_questInstance.ActiveTask.Title);
    }

    public void CompleteTask()
    {
        _questInstance.Complete();
    }

    
}