using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu(fileName = "New Item", menuName = " Inventory/Item")]
public class Item : ScriptableObject
{

    new public string name = "New Item";
    public string en_name = "New Item_en";
    public Sprite icon = null;
    public bool isDefaultItem = false;
    public bool death = false;
    public bool hallucinations = false;
    
    
 
    public virtual void Use()
    {

        // Uzywanie itemu 
        Debug.Log("Uzyto itemu");
        if(death == true)
        {
            PlayerController player = GameObject.FindObjectOfType<PlayerController>();
            player.RestartLevel();
        }

     
        
    }

    


}
