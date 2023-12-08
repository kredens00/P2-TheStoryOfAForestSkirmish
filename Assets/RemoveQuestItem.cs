using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveQuestItem : MonoBehaviour
{
    private Inventory _inventory;
    public Item item;
    // Start is called before the first frame update
    void Start()
    {
        _inventory = GameObject.Find("GameManager").GetComponent<Inventory>();
    }
    public void RemoveItem()
    {
        if (_inventory.items.Contains(item))
        {

           _inventory.Remove(item); 

        }
    }

    // Update is called once per frame
    
}
