using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class But : MonoBehaviour
{
    private Inventory _inventory;
    public Item item;
    public GameObject swinia_1;
    public GameObject swinia_2;
    // Start is called before the first frame update


   void Start()
    {
        _inventory = GameObject.Find("GameManager").GetComponent<Inventory>();
    }
    void Update()
    {
       
        if(_inventory.items.Contains(item))
        {
           
            swinia_1.SetActive(false);
            swinia_2.SetActive(true);
        }
    }

    
   
}
