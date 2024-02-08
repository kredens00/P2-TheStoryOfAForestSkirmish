using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableScroll : MonoBehaviour
{
    private ScrollRect scrollRect;

    void Start()
    {
        // Pobierz komponent ScrollRect z obiektu
        scrollRect = GetComponent<ScrollRect>();

        if (scrollRect != null)
        {
            // Ustaw czułość scrollowania na 0, co praktycznie wyłączy scrollowanie
            scrollRect.scrollSensitivity = 0f;

            // Wyłącz możliwość przenoszenia obiektu
            scrollRect.horizontal = false;
            scrollRect.vertical = false;
        }
        else
        {
            Debug.LogWarning("ScrollRect component not found on this GameObject!");
        }
    }
}
