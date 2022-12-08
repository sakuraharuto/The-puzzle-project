using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStepSound : MonoBehaviour
{
    [SerializeField] AudioSource footStepSound;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {   
            /*
            if (!walkSound.isPlaying)
            {
                walkSound.Play();
            }
            */
            footStepSound.enabled = true;
        }
        else
        {
            //walkSound.Stop();
            footStepSound.enabled = false;
        }
    }
}
