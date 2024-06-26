using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingChange : MonoBehaviour
{
    
    public float fadeInDuration = 1.0f; // Czas trwania efektu fade in
    public float displayDuration = 3.0f; // Czas wyświetlania obrazka
    public float fadeOutDuration = 1.0f; // Czas trwania efektu fade out
    public string nextLevelToLoad; // Nazwa sceny, którą chcesz załadować po wyświetleniu obrazka

    private float alpha = 0.0f;
    private float startTime;
    private bool fadingIn = true;
    private bool displayingImage = false;
    private bool fadingOut = false;
    GameObject _player;
    GameObject inventory;


    void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        Destroy(_player);
        inventory = GameObject.Find("GameManager");
        Destroy(inventory);

        
    }
    void Start()
    {
        StartCoroutine(FadeInOut());
    }

    IEnumerator FadeInOut()
    {
        startTime = Time.time;

        while (fadingIn)
        {
            float elapsedTime = Time.time - startTime;
            alpha = Mathf.Clamp01(elapsedTime / fadeInDuration);

            if (elapsedTime >= fadeInDuration)
            {
                fadingIn = false;
                startTime = Time.time;
                displayingImage = true;
            }

            yield return null;
        }

        while (displayingImage)
        {
            if (Time.time - startTime >= displayDuration)
            {
                startTime = Time.time;
                displayingImage = false;
                fadingOut = true;
            }
            yield return null;
        }

        while (fadingOut)
        {
            float elapsedTime = Time.time - startTime;
            alpha = 1.0f - Mathf.Clamp01(elapsedTime / fadeOutDuration);

            if (elapsedTime >= fadeOutDuration)
            {
                fadingOut = false;
                SceneManager.LoadScene(nextLevelToLoad);
            }

            yield return null;
        }
    }

 
}

