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
    public string npcID;
    public GameObject npc;
    


    private void Start()
    {
        if (PlayerPrefs.HasKey(npcID))
        {
            Destroy(gameObject);
            if(npc != null)
            {
                npc.SetActive(true);
            }
                
           
            
        }

        
    }

    public void OnCollisionEnter(Collision collision)
    {
        PlayerController playerController = GameObject.FindObjectOfType<PlayerController>();
        

        isTalking = true;
        dialogCanvas.SetActive(true);
        if(isTalking)
        {
            

            if (collision.gameObject.CompareTag("Player") == true && !isFinished)
            {
                if (npcID != "")
                {
                    PlayerPrefs.SetInt(npcID, 1);
                    PlayerPrefs.Save();
                }

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

        isTalking = false;



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

