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
        var nextScene = SceneManager.GetSceneByName(scene);
        

       // StartCoroutine(SetActive(nextScene));
        
    }

    private void SetGameObjectsActive(GameObject[] objects, bool active)
    {
        for (int i = 0; i < objects.Length; i++)
        {
            objects[i].gameObject.SetActive(active);
        }
    }

   /* public IEnumerator SetActive(Scene scene)
    {
        int i = 0;
        while (i < 1)
        {
            SetGameObjectsActive(SceneManager.GetActiveScene().GetRootGameObjects(), false);
            i++;
            yield return null;
        }
        SceneManager.SetActiveScene(scene);
        yield break;
    }*/
}
