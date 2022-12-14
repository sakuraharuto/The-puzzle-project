using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PauseManager : MonoBehaviour
{
    bool isPaused;
    [SerializeField] TextMeshProUGUI pauseText;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !isPaused)
        {
            PauseGame();
            isPaused = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isPaused)
        {
            ResumeGame();
            isPaused = false;
        }
    }

    void PauseGame()
    {
        Debug.Log("Game paused");
        pauseText.enabled = true;
        pauseText.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    void ResumeGame()
    {
        pauseText.enabled = false;
        pauseText.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public bool GetPauseStatus()
    {
        return isPaused;
    }
}
