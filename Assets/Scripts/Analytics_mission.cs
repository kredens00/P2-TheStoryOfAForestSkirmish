using System;
using System.Collections.Generic;
using Unity.Services.Analytics;
using UnityEngine;
using UnityEngine.Analytics;


public class Analytics_mission : MonoBehaviour
{
    public string questId;
    public Menu_hide consent;
    // Start is called before the first frame update
    void Start()
    {
        consent = GameObject.Find("Menu_hide").GetComponent<Menu_hide>();
    }
    public void OnMissionCompleted()
    {
    
        
            Dictionary<string, object> data = new Dictionary<string, object>()
        {
            {"questName", $"{questId}" }


        };
            AnalyticsService.Instance.CustomData("missionCompleted", data);
            AnalyticsService.Instance.Flush();
            Debug.Log("Event sent");
        
        //Analytics.CustomEvent("missionCompleted");
  
        
    }
}
