using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SecretDoorController : MonoBehaviour
{
    [SerializeField] PlayerStatus status;
    [SerializeField] Animator secretDoor;
    [SerializeField] bool isSecretDoorOpen;
    [SerializeField] TextMeshProUGUI keyHint;


    private void OnTriggerStay(Collider other)
    {
        bool isPlayerKnowTheKey = status.GetTheKeyStatus();

        if (other.tag == "Player" && isPlayerKnowTheKey)
        {
            keyHint.enabled = true;
            keyHint.gameObject.SetActive(true);
        }

        if (other.tag == "Player" && isPlayerKnowTheKey && !isSecretDoorOpen && Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log("You opened the secret door!");
            OpenTheSecretDoor();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        keyHint.enabled = false;
        keyHint.gameObject.SetActive(false);
    }

    void OpenTheSecretDoor()
    {
        secretDoor.Play("CupboardOpen");
        isSecretDoorOpen = true;
        keyHint.enabled = false;
        keyHint.gameObject.SetActive(false);
        gameObject.SetActive(false);
    }
}
