using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Cinemachine;
using UnityEngine.SceneManagement;
public class jump_death : MonoBehaviour
{

    private NavMeshAgent agent;
    
    private GameObject player;
    private bool isDead;
    public Camera camera2;
    Vector3 posY;
    
    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
    }

    // Update is called once per frame
    public void OnTriggerEnter(UnityEngine.Collider other)
    {
       
      
        
        player = GameObject.FindGameObjectWithTag("Player");
        if(other.gameObject.CompareTag("Player") == true)
        {
           
            StartCoroutine(Death());
        }
           
        
    }

    private IEnumerator Death()
    {
        Camera camera = GameObject.FindObjectOfType<Camera>();
        NavMeshAgent agent = GameObject.FindObjectOfType<NavMeshAgent>();
        PlayerController controller = agent.GetComponent<PlayerController>();
        Destroy(camera);
        camera2.enabled = true;
        
        Debug.Log("colliding");
        controller.enabled = false;
        agent.enabled = false;
        isDead = true;
        if (isDead == true)
           yield return new WaitForSeconds(3);
        PlayerInstance.Destroy(player);
        SceneManager.LoadScene("Smierc_most");
    }
}
