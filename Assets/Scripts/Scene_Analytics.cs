using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using Unity.Services.Analytics;
using Unity.Services.Core;

public class Scene_Analytics : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (UnityServices.State == ServicesInitializationState.Initialized)
        {
            Analytics.CustomEvent("dumpVisited");

            AnalyticsService.Instance.CustomData("dumpVisited");
            AnalyticsService.Instance.Flush();
            Debug.Log("Event sent");
        }
        else
        {
            Debug.Log("Analytics not initialized");
        }

    }

  
}
