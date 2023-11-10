using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Analytics;

public class Analitics : MonoBehaviour
{
    async void Start()
    {
        await UnityServices.InitializeAsync();

        
    }

    public void ConsentGiven()
    {
        AnalyticsService.Instance.StartDataCollection();
    }
}
