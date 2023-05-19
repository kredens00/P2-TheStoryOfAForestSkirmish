using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest_UI : MonoBehaviour
{
    public static Quest_UI instance;
    public GameObject questUI;
   
   
    
    
    // Start is called before the first frame update

  /*  private void Awake()
    {
        if (instance != null)

        {
            Destroy(gameObject);

        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
        }
    }
        void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Quest"))
        {

            questUI.SetActive(!questUI.activeSelf);
        }
    }
}
