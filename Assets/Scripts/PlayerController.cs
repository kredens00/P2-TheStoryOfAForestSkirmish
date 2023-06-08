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
    private Animator animator;
    private SpriteRenderer sprite;
    bool isSprinting;


    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();

    }
    void Update()
    {
        
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        bool isMoving = Mathf.Abs(moveHorizontal) > 0.1f || Mathf.Abs(moveVertical) > 0.1f;
        
        if (isMoving)
        {
            animator.SetBool("Walking", true);
            if (moveHorizontal < 0)
            {
                sprite.flipX = true;
            }
            else
            {
                sprite.flipX = false;
            }
        }
        else
        {
            animator.SetBool("Walking", false);
        }

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.position += movement * walkSpeed * Time.deltaTime;
        Sprint();
        
        
       


        if (Input.GetMouseButtonDown(0))
        {

            transform.position += (movement + hit.point) * walkSpeed * Time.deltaTime;

        }
    }

    void Sprint()
    {
        
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            
            walkSpeed = sprintSpeed;
            animator.SetBool("Running", true);
        } else
        {
            walkSpeed = 8;
            animator.SetBool("Running", false);
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