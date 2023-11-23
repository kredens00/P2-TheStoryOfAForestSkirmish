using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeInstance : MonoBehaviour
{
    #region Singleton
    public static VolumeInstance Instance;

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

}
