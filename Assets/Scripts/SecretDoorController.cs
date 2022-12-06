using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretDoorController : MonoBehaviour
{
    [SerializeField] PlayerStatus status;
    [SerializeField] Animator secretDoor;
    [SerializeField] bool isSecretDoorOpen;

    private void OnTriggerStay(Collider other) {
        bool isPlayerKnowTheKey = status.GetTheKeyStatus();

        if (other.tag == "Player" && isPlayerKnowTheKey && !isSecretDoorOpen && Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log("You opened the secret door!");
            OpenTheSecretDoor();
        }
    }

    void OpenTheSecretDoor()
    {
        secretDoor.Play("CupboardOpen");
        isSecretDoorOpen = true;
    }
}
