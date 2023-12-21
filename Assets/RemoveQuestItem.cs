using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveQuestItem : MonoBehaviour
{
    private Inventory _inventory;
    public Item item;
    public bool canRemove = false;
    // Start is called before the first frame update
    void Start()
    {
        _inventory = GameObject.Find("GameManager").GetComponent<Inventory>();
    }
    public void RemoveItem()
    {
        if (_inventory.items.Contains(item))
        {
            canRemove = true;
           _inventory.Remove(item); 

        }
    }

    // Update is called once per frame
    
}
