using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Data;

public class MainMenu : MonoBehaviour
{
    public Button startButton;
    public Button exitButton;
    public Button settingsButton;
    public GameObject settingsCanvas;
    public GameObject startCanvas;
    public GameObject destroyInstance;
    void Start()
    {
        // Przypisanie funkcji do przycisków
        startButton.onClick.AddListener(LoadScene);
        exitButton.onClick.AddListener(ExitGame);
        settingsButton.onClick.AddListener(Settings);    
    }
    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            settingsCanvas.SetActive(false);
            startCanvas.SetActive(true);
        }
    }

    void LoadScene()
    {
        // Kod do wykonania po kliknięciu przycisku Start
        Debug.Log("Ładowanie sceny...");
        // Tutaj można dodać kod, który ma zostać wykonany przed załadowaniem nowej sceny

        // Wczytanie nowej sceny o nazwie "NazwaSceny" (zastąpić własną nazwą)
        PlayerPrefs.DeleteAll();
        destroyInstance = GameObject.Find("DontDestroyOnLoad");
        Destroy(destroyInstance );
        SceneManager.LoadScene("Startowy dom");
        
    }

    void ExitGame()
    {
        // Kod do zamknięcia gry
        Debug.Log("Gra została zamknięta.");
        // Wychodzenie z gry (tylko w wersji standalone, nie działa w Unity Editor)
        UnityEditor.EditorApplication.isPlaying = false;    
        Application.Quit();
    }
    void Settings()
        {
            settingsCanvas.SetActive(true);
            startCanvas.SetActive(false);
        } 


}
