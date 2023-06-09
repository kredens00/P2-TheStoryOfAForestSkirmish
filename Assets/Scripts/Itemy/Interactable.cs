using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private bool isClickable = true;
    public float radius = 1f; // maksymalna odległość interakcji
    bool hasInteracted = false;
    


   

    private void Update()
    {
        // znajdź obiekt Player
        PlayerController player = FindObjectOfType<PlayerController>();
       

        // sprawdź, czy gracz jest wystarczająco blisko
        if (isClickable && Vector3.Distance(transform.position, player.transform.position) <= radius)
        {
            // sprawdź, czy klawisz "E" został wciśnięty
            if (Input.GetKeyDown(KeyCode.E) && !hasInteracted )
            {
                
                isClickable = false;
                hasInteracted = true;
                Interact();

               
            }
           
        }
    }
    public virtual void Interact()
    {
        //for overriding
        Debug.Log("Interakcja z " + transform.name);
        
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);


    }

    /*public void ResetObjectPosition()
    {
        
        gameObject.SetActive(true);
        isClickable = true;
        hasInteracted=false;
    }*/
}