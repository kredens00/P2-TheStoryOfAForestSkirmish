using UnityEngine;
using UnityEditor;
using System.Reflection;

public class PlayerPrefsViewerWindow : EditorWindow
{
    [MenuItem("Window/PlayerPrefs Viewer")]
    public static void ShowWindow()
    {
        PlayerPrefsViewerWindow window = GetWindow<PlayerPrefsViewerWindow>("PlayerPrefs Viewer");
        window.Show();
    }

    private void OnGUI()
    {
        GUILayout.Label("PlayerPrefs Viewer", EditorStyles.boldLabel);

        // Pobierz wszystkie klucze z PlayerPrefs przy u¿yciu refleksji
        MethodInfo getPrefsKeysMethod = typeof(PlayerPrefs).GetMethod("GetAllKeys", BindingFlags.Static | BindingFlags.NonPublic);
        string[] allKeys = (string[])getPrefsKeysMethod.Invoke(null, null);

        foreach (string key in allKeys)
        {
            string value = PlayerPrefs.GetString(key); // Mo¿esz u¿yæ odpowiedniej metody w zale¿noœci od typu zapisanej wartoœci
            GUILayout.Label(key + ": " + value);
        }
    }
}
