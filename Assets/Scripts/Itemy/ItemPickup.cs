using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : Interactable
{
    public Item item;
    public override void Interact()
    {
        base.Interact();
         PickUp();
    }

    void PickUp()
    {
        Debug.Log("podniesiono " + item.name);
       bool wasPickedUp =  Inventory.Instance.Add(item);
        if (wasPickedUp)
        {
            Destroy(gameObject);
        }

    }
}
