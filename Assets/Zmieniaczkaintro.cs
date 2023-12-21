using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zmieniaczkaintro : MonoBehaviour
{
    public Texture imageToDisplay; // Obrazek do wyœwietlenia
    public float fadeInDuration = 1.0f; // Czas trwania efektu fade in
    public float displayDuration = 3.0f; // Czas wyœwietlania obrazka
    public float fadeOutDuration = 1.0f; // Czas trwania efektu fade out
    public string nextLevelToLoad; // Nazwa sceny, któr¹ chcesz za³adowaæ po wyœwietleniu obrazka

    private float alpha = 0.0f;
    private float startTime;
    private bool fadingIn = true;
    private bool displayingImage = false;
    private bool fadingOut = false;

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

    void OnGUI()
    {
        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), imageToDisplay);
    }
}

