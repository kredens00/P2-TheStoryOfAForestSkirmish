using CleverCrow.Fluid.QuestJournals;
using System.Collections;
using System.Collections.Generic;
using Unity.Services.Analytics;
using Unity.Services.Core;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{

    public Item item;
    private Inventory _inventory;
    string endingId;
    private GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        _inventory = GameObject.Find("GameManager").GetComponent<Inventory>();

    }

    // Update is called once per frame
    public void LoadEnding()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        PlayerInstance.Destroy(player);
        PlayerPrefs.DeleteAll();
        Inventory inv = GameObject.FindObjectOfType<Inventory>();
        InventoryUI invUI = GameObject.FindObjectOfType<InventoryUI>();
        QuestJournalManager qMenu = GameObject.FindObjectOfType<QuestJournalManager>();
        Destroy(qMenu);
        Destroy(invUI);
        Destroy(inv);

        Dictionary<string, object> data = new Dictionary<string, object>()
        {
            {"gameEnding", $"{endingId}" }


        };

        if (_inventory.items.Contains(item))
        {
            if (UnityServices.State == ServicesInitializationState.Initialized)
            {

                endingId = "GoodEnding";
                AnalyticsService.Instance?.CustomData("gameDone", data);
                AnalyticsService.Instance?.Flush();
                Debug.Log("Event sent");
                SceneManager.LoadScene("GoodEnding1");
            } else
            {
                SceneManager.LoadScene("GoodEnding1");
            }
            
        }
        else
        {
            if (UnityServices.State == ServicesInitializationState.Initialized)
            {
                endingId = "BadEnding";
                AnalyticsService.Instance?.CustomData("gameDone", data);
                
                AnalyticsService.Instance?.Flush();
                Debug.Log("Event sent");
                SceneManager.LoadScene("BadEnding");
            } else
            {
                SceneManager.LoadScene("BadEnding");
            }
           
        }
    }
}
