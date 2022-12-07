using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LetterController : MonoBehaviour
{
    [SerializeField] PlayerStatus status;
    [SerializeField] TextMeshProUGUI pickUpPrompt;

    private void OnTriggerStay(Collider other)
    {
        bool isPlayerHasTheLetter = status.GetTheLetterStatus();

        if (!isPlayerHasTheLetter)
        {
            // Show pickup prompt
            pickUpPrompt.enabled = true;
            pickUpPrompt.gameObject.SetActive(true);
            // The player press F to pick up the letter and disable this game object

            if (Input.GetKeyDown(KeyCode.F))
            {
                status.SetLetterStatus(true);
                Debug.Log("You picked up the letter");
                Debug.Log("The status of the letter is " + status.GetTheLetterStatus());
                status.ShowLetterTheFirstTime();

                pickUpPrompt.enabled = false;
                pickUpPrompt.gameObject.SetActive(false);
                gameObject.SetActive(false);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        pickUpPrompt.enabled = false;
        pickUpPrompt.gameObject.SetActive(false);
    }
}
