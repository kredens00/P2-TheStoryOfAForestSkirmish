using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsentInstance : MonoBehaviour
{

    #region Singleton
    public static ConsentInstance Instance;
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
    public bool Consent = false;

    public void ChangeConsent()
    {
        Consent= true;
    }
       
    
}
    
   

