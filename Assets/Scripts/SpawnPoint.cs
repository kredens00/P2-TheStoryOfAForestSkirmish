using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpawnPoint : MonoBehaviour
{

    private Transform transf;

    private bool startIsSet;
    // Start is called before the first frame update
    void Start()
    {
        transf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!startIsSet)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            NavMeshAgent agent = player.GetComponent<NavMeshAgent>();
            

            if(player != null)
            {
                GameObject start = null;

                if(PlayerInstance.respNr != null && !PlayerInstance.respNr.Equals(""))
                    {
                    start = GameObject.Find(PlayerInstance.respNr);
                }

                Vector3 pos = transf.position;
                if(start != null)
                {
                    pos = start.GetComponent<Transform>().position;
                    agent.enabled = false;
                }
                
                player.GetComponent<Transform>().position = pos;
                startIsSet = true;
                agent.enabled = true;
            }
        }
    }
}
