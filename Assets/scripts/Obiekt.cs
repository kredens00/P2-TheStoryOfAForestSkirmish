using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obiekt : MonoBehaviour
{
    private bool isClickable = true;
    private float interactionDistance = 0.3f; // maksymalna odległość interakcji

    private void Update()
    {
        // znajdź obiekt "Block" w scenie
        Block block = FindObjectOfType<Block>();

        // sprawdź, czy gracz jest wystarczająco blisko
        if (isClickable && Vector3.Distance(transform.position, block.transform.position) <= interactionDistance)
        {
            // sprawdź, czy klawisz "E" został wciśnięty
            if (Input.GetKeyDown(KeyCode.E))
            {
                isClickable = false;
                gameObject.SetActive(false);
                ResetObjectPosition();
            }
        }
    }

    public void ResetObjectPosition()
    {
        transform.position = Vector3.zero;
        gameObject.SetActive(true);
        isClickable = true;
    }
}