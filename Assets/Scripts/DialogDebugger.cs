using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cherrydev;

public class DialogDebugger : MonoBehaviour
{

    #region Singleton
    public static DialogDebugger Instance;

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

    #endregion

    public GameObject DialogBox;
    public PlayerController Player;
    
    // Start is called before the first frame update
    void Start()
    {
        
        Player = FindObjectOfType<PlayerController>();
        
    }

    // Update is called once per frame
    void Update()
    {
       
       DialogBox = GameObject.Find("DialogBox");

       if(DialogBox != null){
            if (!Player.enabled && (DialogBox.activeSelf == false || DialogBox == null))
            {
                Player.enabled = true;
            }
        }
       
    }
}
