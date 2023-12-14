using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Rendering;

public class Hallucinations : MonoBehaviour
{

    Item item;
    public bool isTripping = false;
    public bool tripIn = false;
    public bool tripOut = false;
    readonly float TimetoHal = 1;

    // Start is called before the first frame update
    public void Trip()
    {
        if(item.hallucinations == true )
        {
            StartCoroutine(Tripping());
        }
    }

    private void Update()
    {
        Volume volume = FindObjectOfType<Volume>();
        if (tripIn== true ) 
        {

            if (volume.weight < 1)
            {
                volume.weight += TimetoHal * Time.deltaTime;
                if (volume.weight >= 1)
                {
                    tripIn = false;
                }
            }
        }
       
        if (tripOut == true )
        
        {
            if (volume.weight >= 0)
            {
                volume.weight -= TimetoHal * Time.deltaTime;
                if(volume.weight == 0) 
                {
                    tripOut = false;
                }
            }
        }
       
    }


    public IEnumerator Tripping()
    {
       tripIn = true;
       
        yield return new WaitForSeconds(15);

        tripOut = true;
        

        
    }

    // Update is called once per frame

}
