using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PickedItemUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        GameObject pickupMenu = GameObject.FindGameObjectWithTag("PickupMenu");
        if (pickupMenu.GetComponent<Image>().enabled == true)
        {
            StartCoroutine(Off());
        }
    }

    public IEnumerator Off()
    {
        yield return new WaitForSeconds(1);
        GameObject pickupMenu = GameObject.FindGameObjectWithTag("PickupMenu");
        pickupMenu.GetComponentInChildren<TextMeshProUGUI>().text = "Podniesiono: ";
        pickupMenu.GetComponentInChildren<TextMeshProUGUI>().enabled = false;
        pickupMenu.GetComponent<Image>().enabled = false;
    }
}
