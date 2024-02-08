using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_hide : MonoBehaviour
{
    #region Singleton
    public static Menu_hide Instance;
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


    public bool langIsSet = false;
    public bool agrIsSet = false;
    public bool isConsent = false;
   

    // Start is called before the first frame update
   

    // Update is called once per frame
    public void ChangeLangBool()
    {
        langIsSet= true;
    }

    public void ChangeAgrBool()
    {
        agrIsSet= true;
    }

    public void Consent()
    {
        isConsent = true;
    }
}
