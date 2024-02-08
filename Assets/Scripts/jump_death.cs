using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Cinemachine;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;
using Unity.Services.Analytics;
using Unity.Services.Core;
using CleverCrow.Fluid.QuestJournals;

public class jump_death : MonoBehaviour
{

    
    
    private GameObject player;
    private bool isDead;
    public Camera camera2;
    
    
    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
    }

    // Update is called once per frame
    public void OnTriggerEnter(UnityEngine.Collider other)
    {
       
      
        
        player = GameObject.FindGameObjectWithTag("Player");
        if(other.gameObject.CompareTag("Player") == true)
        {
           
            StartCoroutine(Death());
        }
           
        
    }

    private IEnumerator Death()
    {
       
        NavMeshAgent agent = GameObject.FindObjectOfType<NavMeshAgent>();
        PlayerController controller = agent.GetComponent<PlayerController>();
        
        camera2.enabled = true;
        
        Debug.Log("colliding");
        controller.enabled = false;
        agent.enabled = false;
        
        isDead = true;
        if (isDead == true)
           yield return new WaitForSeconds(3);
        PlayerInstance.Destroy(player);
        PlayerPrefs.DeleteAll();
        Inventory inv = GameObject.FindObjectOfType<Inventory>();
        InventoryUI invUI = GameObject.FindObjectOfType<InventoryUI>();
        QuestJournalManager qMenu = GameObject.FindObjectOfType<QuestJournalManager>();
        Destroy(qMenu);
        Destroy(invUI);
        Destroy(inv);
        SceneManager.LoadScene("Smierc_most");
        OnFallEvent();
    }

    private void OnFallEvent()
    {
        if (UnityServices.State == ServicesInitializationState.Initialized)
        {
            Analytics.CustomEvent("BridgeDeath");
            AnalyticsService.Instance.CustomData("BridgeDeath");
            AnalyticsService.Instance.Flush();
            Debug.Log("Event sent");
        } else
        {
            Debug.Log("Analytics not initialized");
            return;
        }
       
    }
}
