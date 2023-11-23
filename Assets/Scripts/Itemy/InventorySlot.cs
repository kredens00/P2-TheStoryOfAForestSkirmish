using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.Rendering;

public class InventorySlot : MonoBehaviour
{

    public Image icon;
    Item item;

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

    public IEnumerator Hallucinations()
    {
        Volume volume = GameObject.FindObjectOfType<Volume>();
        volume.enabled = true;
        yield return new WaitForSeconds(15);
        volume.enabled=false;

    }
}
