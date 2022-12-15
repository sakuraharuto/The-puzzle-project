using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheEndManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
        Debug.Log("Game quitted on editor mode");
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
