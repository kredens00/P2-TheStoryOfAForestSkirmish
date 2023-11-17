using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideWindows : MonoBehaviour
{
    
    public GameObject langWindow;
    public GameObject agrWindow;
    public GameObject mainWindow;
    // Start is called before the first frame update
    void Start()
    {

        if (Menu_hide.Instance.langIsSet)
        {
            langWindow.SetActive(false);
        }
        if (Menu_hide.Instance.agrIsSet)
        {
            agrWindow.SetActive(false);
            mainWindow.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
