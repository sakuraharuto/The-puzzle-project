using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
