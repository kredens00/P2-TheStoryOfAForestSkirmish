using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class But : MonoBehaviour
{
    private Inventory inventory;
    public Item item;
    public GameObject swinia_1;
    public GameObject swinia_2;
    // Start is called before the first frame update
    
    private void Awake()
    {
        Inventory inventory = GetComponent<Inventory>();
    }
    void Start()
    {
       
        if(inventory.items.Contains(item))
        {
            swinia_1.SetActive(false);
            swinia_2.SetActive(true);
        }
    }

    
   
}
