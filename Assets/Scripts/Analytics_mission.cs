using System;
using System.Collections.Generic;
using Unity.Services.Analytics;
using UnityEngine;
#if ENABLE_CLOUD_SERVICES_ANALYTICS
using UnityEngine.Analytics;
#endif

public class Analytics_mission : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnMissionCompleted()
    {
        Dictionary<string, object> parameters = new Dictionary<string, object>()
        {
            {"isDone", "true" }
        };
        AnalyticsService.Instance.CustomData("missionCompleted", parameters);
        Debug.Log("Event sent");
        
    }
}
