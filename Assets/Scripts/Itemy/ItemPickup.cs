using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
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
        
       
      if (PlayerPrefs.GetInt("LocaleKey") == 1)
        {
            item.name = item.en_name;
        }
        textUi.enabled= true;
        textUi.text += item.name;

        pickupUi.GetComponent<Image>().enabled = true;

        yield return null;
        Debug.Log("1 sekunda");
        
        

       /* GameObject pickupUi1 = GameObject.FindGameObjectWithTag("PickupMenu");
        pickupUi1.SetActive(false);

        TextMeshProUGUI textUi1 = pickupUi1.GetComponentInChildren<TextMeshProUGUI>();

        textUi1.text = "";
        pickupUi1.GetComponent<Image>().enabled = false;
        textUi1.enabled = false;
        yield return null;*/
        
        
        

    }
    public IEnumerator CloseUi()
    {
        yield return new WaitForSeconds(1);
        GameObject pickupUi1 = GameObject.FindGameObjectWithTag("PickupMenu");
        
        TextMeshProUGUI textUi1 = pickupUi1.GetComponentInChildren<TextMeshProUGUI>();

        textUi1.text = "Podniesiono: ";
        pickupUi1.GetComponent<Image>().enabled = false;
        textUi1.enabled = false;
        
        
    }
}
