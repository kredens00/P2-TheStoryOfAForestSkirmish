using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipScene : MonoBehaviour
{
    // Indeks aktualnej sceny
    private int currentSceneIndex;

    void Start()
    {
        // Pobierz indeks aktualnej sceny na starcie
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }
    void Update()
{
    // Sprawdź, czy naciśnięto przycisk spacji i czy jesteśmy w jednej z pierwszych trzech scen
    if (Input.GetKeyDown(KeyCode.Space) && currentSceneIndex <= 4 )
    {
        // Przejdź do kolejnej sceny
        SceneManager.LoadScene(5);
    }
}

}
