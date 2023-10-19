using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drogowskaz : MonoBehaviour
{
    public float radius = 1f;
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerController player = FindObjectOfType<PlayerController>();
        if (Vector3.Distance(transform.position, player.transform.position) <= radius)
        {
            canvas.SetActive(true);
       
        } else
        {
            canvas.SetActive(false);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);


    }
}
   

