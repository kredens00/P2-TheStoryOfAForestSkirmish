using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obiektr : MonoBehaviour
{
    public GameObject objectToInteractWith;
    private bool canInteract = true;

    private void Update()
    {
        if (canInteract && Input.GetKeyDown(KeyCode.E) && IsPlayerNearObject())
        {
            objectToInteractWith.SetActive(false);
            transform.position = new Vector3(-1, 1, -12);
        }
    }

    private bool IsPlayerNearObject()
    {
        float distance = Vector3.Distance(transform.position, objectToInteractWith.transform.position);
        return distance < 2f; // Załóżmy, że interakcja jest możliwa tylko jeśli gracz jest w odległości 2 jednostek od obiektu
    }
}