using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate_key : MonoBehaviour
{
    public string gateID;
    // Start is called before the first frame update
   public void SaveGatePrefs()
    {
        PlayerPrefs.SetInt(gateID, 1);
        PlayerPrefs.Save();
    }

    // Update is called once per frame
   
}
