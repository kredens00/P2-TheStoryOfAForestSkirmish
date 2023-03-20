using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public float speed = 1f;


void Update()
{
    float moveHorizontal = Input.GetAxis("Horizontal");
    float moveVertical = Input.GetAxis("Vertical");

    Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

    Sprint();

    transform.position += movement * speed * Time.deltaTime;

}

    void Sprint()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 2.0f;
        }

        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 1f;
        }
    }
}