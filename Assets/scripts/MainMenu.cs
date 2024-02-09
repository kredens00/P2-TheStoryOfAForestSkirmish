using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button startButton;
    public Button exitButton;
    public Button settingsButton;
    public GameObject settingsCanvas;
    public GameObject startCanvas;
    public GameObject playerInstance;
    GameObject inventory;
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
        PlayerPrefs.DeleteAll();
        playerInstance = GameObject.FindGameObjectWithTag("Player");
        Destroy(playerInstance);
        inventory = GameObject.Find("GameManager");
        Destroy(inventory);

        // Kod do wykonania po kliknięciu przycisku Start
        Debug.Log("Ładowanie sceny...");
        // Tutaj można dodać kod, który ma zostać wykonany przed załadowaniem nowej sceny

        // Wczytanie nowej sceny o nazwie "NazwaSceny" (zastąpić własną nazwą)
        SceneManager.LoadScene("IntroScena0");
    }

    void ExitGame()
    {
        // Kod do zamknięcia gry
        Debug.Log("Gra została zamknięta.");
        // Wychodzenie z gry (tylko w wersji standalone, nie działa w Unity Editor)
        Application.Quit();
    }
    void Settings()
        {
            settingsCanvas.SetActive(true);
            startCanvas.SetActive(false);
        } 


}
