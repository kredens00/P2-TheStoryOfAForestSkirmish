using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public float walkSpeed = 3f;
    public float sprintSpeed = 5f;


void Update()
{
    float moveHorizontal = Input.GetAxis("Horizontal");
    float moveVertical = Input.GetAxis("Vertical");

    Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

    Sprint();

    transform.position += movement * walkSpeed * Time.deltaTime;

}

    void Sprint()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            walkSpeed = sprintSpeed;
        }
      

        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            walkSpeed = 3f;
        }
    }
}