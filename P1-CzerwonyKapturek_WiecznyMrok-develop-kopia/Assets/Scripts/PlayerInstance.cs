using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInstance : MonoBehaviour
{

    public static PlayerInstance instance;
    public static string respNr;
    // Start is called before the first frame update
    void Awake()
    {
        if (!instance)
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
            respNr = "Start1";
        }
        else { 
        
        Destroy(gameObject);
        }
    }

    // Update is called once per frame
   
}
