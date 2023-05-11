using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcDialog : MonoBehaviour
{

    public DialogTrigger trigger;
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player") == true)
        {
            trigger.StartDialogue();
        }
    }
}
