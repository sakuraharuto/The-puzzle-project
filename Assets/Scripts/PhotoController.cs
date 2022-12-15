using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PhotoController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI pickUpPhotoPrompt;
    [SerializeField] TextMeshProUGUI readPhotoPrompt;
    [SerializeField] float loadSceneDelay = 1.5f;

    private void OnTriggerStay(Collider other)
    {
        pickUpPhotoPrompt.enabled = true;
        pickUpPhotoPrompt.gameObject.SetActive(true);

        if (Input.GetKeyDown(KeyCode.F))
        {
            pickUpPhotoPrompt.enabled = false;
            pickUpPhotoPrompt.gameObject.SetActive(false);
            StartCoroutine(ShowMessageAndLoad(loadSceneDelay));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        pickUpPhotoPrompt.enabled = false;
        pickUpPhotoPrompt.gameObject.SetActive(false);
    }

    IEnumerator ShowMessageAndLoad(float delay)
    {
        readPhotoPrompt.enabled = true;
        readPhotoPrompt.gameObject.SetActive(true);
        yield return new WaitForSeconds(delay);

        Debug.Log("Loading...");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
