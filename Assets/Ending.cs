using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{

    public Item item;
    private Inventory _inventory;
    // Start is called before the first frame update
    void Start()
    {
        _inventory = GameObject.Find("GameManager").GetComponent<Inventory>();

    }

    // Update is called once per frame
    public void LoadEnding()
    {
        if(_inventory.items.Contains(item))
        {
            SceneManager.LoadScene("GoodEnding1");
        }
        else
        {
            SceneManager.LoadScene("BadEnding1");
        }
    }
}
