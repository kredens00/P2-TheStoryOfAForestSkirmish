using cherrydev;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcDialog : MonoBehaviour
{

    //public DialogTrigger trigger;
    [SerializeField]
    private DialogBehaviour trigger;
    [SerializeField]
    private DialogNodeGraph graph;
    [SerializeField]
    private DialogNodeGraph graph_finished;
    private bool isFinished;
    
   
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player") == true && !isFinished)
        {
            trigger.StartDialog(graph);
            isFinished = true;
        }
        else
        {
            if(graph_finished != null)
            {
                trigger.StartDialog(graph_finished);
            }
            
        }
    }

 
}
