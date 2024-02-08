using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    bool SettingsActive = false;

    public GameObject pauseMenuUI;
    public GameObject settingsUI;
    public GameObject Blur;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape) && SettingsActive == true)
        {
            settingsUI.SetActive(false);
            GameIsPaused = false;
            SettingsActive = false;
        }
        if (Input.GetKeyDown(KeyCode.Escape) && SettingsActive == false)
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }

           
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Blur.SetActive(false);
        Time.timeScale = 1;
        GameIsPaused = false;

    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Blur.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }

    public void LoadSettings()
    {
        settingsUI.SetActive(true);
        SettingsActive = true;
       

    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}
