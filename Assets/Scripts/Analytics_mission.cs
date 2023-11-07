using System;
using System.Collections.Generic;
using Unity.Services.Analytics;
using UnityEngine;
using UnityEngine.Analytics;


public class Analytics_mission : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnMissionCompleted()
    {
     
        Analytics.CustomEvent("missionCompleted");
        
        AnalyticsService.Instance.CustomData("missionCompleted");
        AnalyticsService.Instance.Flush();
        Debug.Log("Event sent");
        
    }
}
