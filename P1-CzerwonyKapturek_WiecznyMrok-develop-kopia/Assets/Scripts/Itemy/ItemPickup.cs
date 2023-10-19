using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


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
}
