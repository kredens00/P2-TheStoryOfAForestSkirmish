using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ItemPickup : Interactable
{
    public static ItemPickup Instance;
    [SerializeField]
    public UnityEvent tasks;
    public Item item;
    public string itemID;

    private void Start()
    {
        if (PlayerPrefs.HasKey(itemID))
        {
            Destroy(gameObject);
        }
    }
    public override void Interact()
    {
        base.Interact();
         PickUp();
    }

    public void PickUp()
    {
        Debug.Log("podniesiono " + item.name);
      bool wasPickedUp =  Inventory.Instance.Add(item);
        if (wasPickedUp)
        {
            
            tasks.Invoke();
            SavePickedUpItem();
            Destroy(gameObject);
           
            StartCoroutine(PickUpUi());
        }

    }

    private void SavePickedUpItem()
    {
        if(item != null)
        {
            PlayerPrefs.SetInt(itemID, 1);
            PlayerPrefs.Save();
        }
       
        
    }

    public IEnumerator PickUpUi()
    {
        GameObject pickupUi = GameObject.FindGameObjectWithTag("PickupMenu");
        
        
        TextMeshProUGUI textUi = pickupUi.GetComponentInChildren<TextMeshProUGUI>();
        
        
        textUi.enabled= true;
        textUi.text += item.name;

        pickupUi.GetComponent<Image>().enabled = true;

        yield return new WaitForSeconds(1);

        textUi.text = "";
        pickupUi.GetComponent<Image>().enabled = false;
        textUi.enabled = false;


    }
}
