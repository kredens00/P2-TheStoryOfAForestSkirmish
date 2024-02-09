using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public string scene;
    public string respNr;

    FadeInOut fade;

    private void Start()
    {
        fade = FindObjectOfType<FadeInOut>();
    }

    public IEnumerator ChangeScene()
    {
        fade.FadeIn();
        yield return new WaitForSeconds(1);
        LoadLevel();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(ChangeScene());
            PlayerInstance.respNr = respNr;
            
        }
    }

    public void LoadLevel()
    {
        
        SceneManager.LoadScene(scene);
        
    }

   

  
}
