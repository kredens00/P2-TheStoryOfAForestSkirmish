using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.Rendering;

public class InventorySlot : MonoBehaviour
{
    readonly float timeToHal = 1;
    public Image icon;
    Item item;
    public bool tripIn = false;
    public bool tripOut = false;    

    public void AddItem (Item newItem)
    {
        item = newItem;

        icon.sprite = item.icon;
        icon.enabled = true;
    }

    public void ClearSlot()
    {
        item = null;

        icon.sprite = null;
        icon.enabled=false;
    }

    public void OnRemoveButton()
    {
        Inventory.Instance.Remove(item);
    }

    public void UseItem ()
    {
        if (item != null)
        {
            item.Use();
            if(item.hallucinations == true)
            {
                StartCoroutine(Hallucinations());
            }
        }
    }


    void Update()
    {
        Volume volume = GameObject.FindObjectOfType<Volume>();
        if (tripIn == true)
        {

            if (volume.weight < 1)
            {
                volume.weight += timeToHal * Time.deltaTime;
                if (volume.weight >= 1)
                {
                    tripIn = false;
                }
            }
        }

        if (tripOut == true)

        {
            if (volume.weight >= 0)
            {
                volume.weight -= timeToHal * Time.deltaTime;
                if (volume.weight <= 0)
                {
                    tripOut = false;
                }
            }
        }
    }
    public IEnumerator Hallucinations()
    {

        tripIn = true;

        yield return new WaitForSeconds(15);

        tripOut = true;

        /* Volume volume = GameObject.FindObjectOfType<Volume>();
         if (volume.weight < 1)
         {
             volume.weight += timeToHal * Time.deltaTime;
         }


         yield return new WaitForSeconds(15);

         if (volume.weight >= 0)
         {
             volume.weight -= timeToHal * Time.deltaTime;

         }
         volume.enabled = false; */
    }

    
}
