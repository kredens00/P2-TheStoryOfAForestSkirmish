using System;
using Unity.Services.Analytics;
using Unity.Services.Core;
using UnityEngine;

public class Analyticsstart : MonoBehaviour
{
    async void Awake()
    {
        try
        {
            await UnityServices.InitializeAsync();
            AnalyticsService.Instance.StartDataCollection();
        }
        catch (Exception e)
        {
            Debug.LogException(e);
        }
    }
}
