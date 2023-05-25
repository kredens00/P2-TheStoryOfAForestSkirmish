using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button startButton;
    public Button exitButton;

    void Start()
    {
        // Przypisanie funkcji do przycisków
        startButton.onClick.AddListener(LoadScene);
        exitButton.onClick.AddListener(ExitGame);
    }

    void LoadScene()
    {
        // Kod do wykonania po kliknięciu przycisku Start
        Debug.Log("Ładowanie sceny...");
        // Tutaj można dodać kod, który ma zostać wykonany przed załadowaniem nowej sceny

        // Wczytanie nowej sceny o nazwie "NazwaSceny" (zastąpić własną nazwą)
        SceneManager.LoadScene("Startowy dom");
    }

    void ExitGame()
    {
        // Kod do zamknięcia gry
        Debug.Log("Gra została zamknięta.");
        // Wychodzenie z gry (tylko w wersji standalone, nie działa w Unity Editor)
        Application.Quit();
    }
}
