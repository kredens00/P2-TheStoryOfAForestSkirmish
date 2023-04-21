using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public string scene;
    public string respNr;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            PlayerInstance.respNr = respNr;
            LoadLevel();
            
        }
    }

    public void LoadLevel()
    {
        
        SceneManager.LoadScene(scene);
    }
}
