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
    
   
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player") == true)
        {
            trigger.StartDialog(graph);
           
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player") == false)
        {
            
        }
    }
}
