using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hallucinations : MonoBehaviour
{

    Item item;
    // Start is called before the first frame update
    public void Trip()
    {
        if(item.hallucinations == true )
        {
            StartCoroutine(Tripping());
        }
    }


    private IEnumerator Tripping()
    {
        GameObject volume = GameObject.FindGameObjectWithTag("Volume");
        volume.SetActive(true);
        yield return new WaitForSeconds(15);
        volume.SetActive(false);

    }

    // Update is called once per frame

}
