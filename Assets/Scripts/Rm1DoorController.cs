using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rm1DoorController : MonoBehaviour
{
    [SerializeField] PressurePadController pressurePad1;
    [SerializeField] PressurePadController pressurePad2;
    [SerializeField] PressurePadController pressurePad3;
    [SerializeField] Animator door;
    AudioSource doorOpenSound;

    void Start()
    {
        doorOpenSound = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {   
        //CheatCode();
        OpenTheDoor();
    }

    bool GetPressurePadStatus(PressurePadController pressurePad)
    {
        return pressurePad.GetPressurePadStatus();
    }

    void OpenTheDoor()
    {
        bool isPad1On = GetPressurePadStatus(pressurePad1);
        bool isPad2On = GetPressurePadStatus(pressurePad2);
        bool isPad3On = GetPressurePadStatus(pressurePad3);

        if (isPad1On && isPad2On && isPad3On)
        {
            Debug.Log("The Door is opened!");
            door.Play("DoorOpenAnim");
            doorOpenSound.Play();
        }
    }

    // For debug use
    void CheatCode()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("The Door is opened! (by cheat code)");
            door.Play("DoorOpenAnim");
            doorOpenSound.Play();
        }
    }
}
