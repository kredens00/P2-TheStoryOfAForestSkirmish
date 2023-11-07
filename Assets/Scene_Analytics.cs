using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using Unity.Services.Analytics;

public class Scene_Analytics : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Analytics.CustomEvent("dumpVisited");

        AnalyticsService.Instance.CustomData("dumpVisited");
        AnalyticsService.Instance.Flush();
        Debug.Log("Event sent");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
