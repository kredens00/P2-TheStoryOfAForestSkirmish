using cherrydev;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;


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
    private DialogNodeGraph graph_en;

    [SerializeField]
    private DialogNodeGraph graph_finished_en;

    [SerializeField]
    public UnityEvent tasks;

    private bool isTalking;
    private bool isFinished = false;
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

    public void OnTriggerEnter(Collider other)
    {
        PlayerController playerController = GameObject.FindObjectOfType<PlayerController>();
        

        isTalking = true;
        dialogCanvas.SetActive(true);
        if(isTalking)
        {
            

            if (other.gameObject.CompareTag("Player") == true && !isFinished)
            {
                if (npcID != "empty")
                {
                    PlayerPrefs.SetInt(npcID, 1);
                    PlayerPrefs.Save();
                }

                if(PlayerPrefs.GetInt("LocaleKey") == 1)
                {
                    if (graph_en != null)
                    trigger.StartDialog(graph_en);
                    isFinished = true;
                    tasks.Invoke();
                } else
                {
                    trigger.StartDialog(graph);
                    isFinished = true;
                    tasks.Invoke();
                }

               
                

            }
           
            else
            {
                if (graph_finished != null)
                {
                    if (PlayerPrefs.GetInt("LocaleKey") == 1)
                    {
                        if(graph_finished_en != null)
                        trigger.StartDialog(graph_finished_en);
                    }
                    else
                    {

                        trigger.StartDialog(graph_finished);

                    }
                }
                
                
               
                
            }

        }

        isTalking = false;



    } 
    

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player") == true)
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

