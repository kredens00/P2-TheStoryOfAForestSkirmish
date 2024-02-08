using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class IntroAudioOff : MonoBehaviour
{

    public static IntroAudioOff Instance;

    private void Awake()
    {
        if (Instance != null)

        {
            Destroy(gameObject);

        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            Instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string sceneoff = SceneManager.GetActiveScene().name;

        if(sceneoff == "Startowy dom")
        {
            Destroy(gameObject);
        }
        
    }
}
