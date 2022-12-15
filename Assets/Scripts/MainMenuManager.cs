using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void QuitGame()
    {
        #if UNITY_EDITOR
        Debug.Log("Game quitted on editor mode");
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }

    public void LoadTheGame()
    {
        Debug.Log("Loading...");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
