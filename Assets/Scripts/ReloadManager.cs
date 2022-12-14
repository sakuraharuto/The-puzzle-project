using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ReloadManager : MonoBehaviour
{

    [SerializeField] float restartDealy = 1f;
    [SerializeField] TextMeshProUGUI restartText;
    [SerializeField] PauseManager pm;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && !pm.GetPauseStatus())
        {
            StartCoroutine(RestartAfterTime(restartDealy));
        }
    }

    IEnumerator RestartAfterTime(float restartDealy)
    {
        restartText.enabled = true;
        restartText.gameObject.SetActive(true);
        yield return new WaitForSeconds(restartDealy);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
