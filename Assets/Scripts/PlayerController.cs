using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{

    public float walkSpeed;
    public float sprintSpeed;
    private RaycastHit hit;
    private NavMeshAgent agent;



    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
{
    float moveHorizontal = Input.GetAxis("Horizontal");
    float moveVertical = Input.GetAxis("Vertical");

    Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

    Sprint();

    transform.position += movement * walkSpeed * Time.deltaTime;


        if(Input.GetMouseButtonDown(0))
        {
           
                transform.position += (movement + hit.point) * walkSpeed *Time.deltaTime;
            
        }
}

    void Sprint()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            walkSpeed = sprintSpeed;
        }
      

       /* if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            walkSpeed = walkSpeed;
        }*/
    }

    //Death
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            RestartLevel();
        }
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene("Startowy dom");
        PlayerInstance.respNr = "Start1";
    }
}