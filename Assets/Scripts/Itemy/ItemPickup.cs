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
            Destroy(gameObject);
            
        }

    }
}
