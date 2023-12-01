using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateChecker : MonoBehaviour
{
    public GameObject open_gate;
    public GameObject close_gate;
    public GameObject gate_collider;
    public string gateID;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey(gateID))
        {
            open_gate.SetActive(true);
            close_gate.SetActive(false);
            gate_collider.SetActive(false);
            Debug.Log("gate open");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
