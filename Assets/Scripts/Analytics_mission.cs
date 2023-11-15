using System;
using System.Collections.Generic;
using Unity.Services.Analytics;
using UnityEngine;
using UnityEngine.Analytics;


public class Analytics_mission : MonoBehaviour
{
    public string questId;
    // Start is called before the first frame update
    public void OnMissionCompleted()
    {
     
        //Analytics.CustomEvent("missionCompleted");
        Dictionary<string, object> data = new Dictionary<string, object>()
        {
            {"questName", $"{questId}" }
        
        
        };
        AnalyticsService.Instance.CustomData("missionCompleted", data);
        AnalyticsService.Instance.Flush();
        Debug.Log("Event sent");
        
    }
}
