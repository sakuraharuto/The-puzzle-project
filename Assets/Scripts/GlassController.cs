using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GlassController : MonoBehaviour
{
    [SerializeField] PlayerStatus status;
    [SerializeField] GameObject glass;
    [SerializeField] TextMeshProUGUI pickUpPrompt;

    private void OnTriggerStay(Collider other)
    {
        bool isPlayerHasGlass = status.GetGlassStatus();

        if (!isPlayerHasGlass)
        {
            //Show pickup prompt
            pickUpPrompt.enabled = true;
            pickUpPrompt.gameObject.SetActive(true);

            // Press F to pick up the glass and disable the game object including glasses

            if (Input.GetKeyDown(KeyCode.F))
            {
                status.SetGlassStatus(true);
                Debug.Log("You picked up the glasses");
                Debug.Log("The status of the glasses is " + status.GetGlassStatus());
                glass.gameObject.SetActive(false);

                // Show a timed message
                status.ShowWearGlassesMessage();

                // Set the player status
                // TODO

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
