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

    public ParticleSystem particleSystem;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        sprite= GetComponent<SpriteRenderer>();
        

    }
    void Update()
    {
         if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            if (!particleSystem.isPlaying)
            {
                particleSystem.Play();
            }
        }

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        
        
            animator.SetFloat("Horizontal", moveHorizontal);
            animator.SetFloat("Vertical", moveVertical);
            animator.SetFloat("Speed", movement.sqrMagnitude);
           
        if(moveHorizontal < 0)
        {
            sprite.flipX = true;
        } else
        {
            sprite.flipX = false;
        }
        
        

        if(Input.GetKey(KeyCode.E)) 
        {

            animator.SetBool("pickup", true);

        } else
        {
            animator.SetBool("pickup", false);
        }

        
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

    public void RestartLevel()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("End_game");
        
        
    }
}