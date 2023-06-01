using cherrydev;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NpcDialog : MonoBehaviour
{

    //public DialogTrigger trigger;
    [SerializeField]
    private DialogBehaviour trigger;

    [SerializeField]
    private DialogNodeGraph graph;

    [SerializeField]
    private DialogNodeGraph graph_finished;
    
    [SerializeField]
    public UnityEvent tasks;

    private bool isTalking;
    private bool isFinished;
    public GameObject dialogCanvas;


    

    private void OnCollisionEnter(Collision collision)
    {
        isTalking = true;
        dialogCanvas.SetActive(true);
        if(isTalking)
        {
            if (collision.gameObject.CompareTag("Player") == true && !isFinished)
            {
                trigger.StartDialog(graph);
                isFinished = true;
                tasks.Invoke();

            }
            else
            {
                if (graph_finished != null)
                {
                    trigger.StartDialog(graph_finished);

                }

            }
        }
       
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player") == true)
        {
            isTalking = false;
            dialogCanvas.SetActive(false);
        }
    }

    public void AddTask(UnityAction action)
    {
        tasks.AddListener(action);
    }



}

