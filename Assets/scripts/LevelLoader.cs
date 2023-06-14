using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class LevelLoader : MonoBehaviour
{
    
    public string scene;
    public string respNr;

    private Scene currentScene;
    private Scene previousScene;
    



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerInstance.respNr = respNr;
            LoadLevel(scene);

        }
    }

    public void LoadLevel(string scene)
    {
        // Pobierz obecn� scen�
        currentScene = SceneManager.GetActiveScene();
        


        // Wy��cz wszystkie obiekty w obecnej scenie
        DisableSceneObjects(currentScene);

        if(!(SceneManager.GetSceneByName(scene).isLoaded))
        {
            // Za�aduj now� scen� addytywnie
            SceneManager.LoadSceneAsync(scene, LoadSceneMode.Additive).completed += OnSceneLoaded;
            
        }
        else
        {
            //UnloadSceneAdditive();
            SceneManager.SetActiveScene(SceneManager.GetSceneByName(scene));
            EnableSceneObjects(SceneManager.GetActiveScene());
        }
        
        

    }

    public void UnloadSceneAdditive()
    {
        // Wy��cz wszystkie obiekty w obecnej scenie
        DisableSceneObjects(currentScene);

        // Wczytaj poprzedni� scen�
        SceneManager.SetActiveScene(previousScene);

        
        EnableSceneObjects(previousScene);
    }

    private void OnSceneLoaded(AsyncOperation operation)
    {
        // Ustaw now� za�adowan� scen� jako aktywn�
        Scene loadedScene = SceneManager.GetSceneAt(SceneManager.sceneCount - 1);
        SceneManager.SetActiveScene(loadedScene);
        
        
        // Zapisz poprzedni� scen�
        previousScene = currentScene;
    }

    private void DisableSceneObjects(Scene scene)
    {
        // Wy��cz wszystkie obiekty w danej scenie
        GameObject[] sceneObjects = scene.GetRootGameObjects();
        foreach (GameObject obj in sceneObjects)
        {
            obj.SetActive(false);
        }
    }

    private void EnableSceneObjects(Scene scene)
    {
        GameObject[] sceneObjects = scene.GetRootGameObjects();
        foreach (GameObject obj in sceneObjects)
        {
            obj.SetActive(true);
        }
    }
}



    



