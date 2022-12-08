using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePadController : MonoBehaviour
{

    [SerializeField] float lockDist;

    [SerializeField] bool isPadOn;

    AudioSource pressDown;
    
    [SerializeField] AudioClip pressDownSound;

    void Awake()
    {
        pressDown = GetComponent<AudioSource>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "key")
        {
            Transform cube = other.GetComponent<Transform>();
            float dist = Vector3.Distance(cube.position, transform.position);

            if (dist < lockDist)
            {
                cube.GetComponent<Rigidbody>().isKinematic = true;
                isPadOn = true;
            }
        }
    }
    void PlaySFX()
    {
        Debug.Log("Sound played");
        pressDown.PlayOneShot(pressDownSound);
    }
    public bool GetPressurePadStatus()
    {
        return isPadOn;
    }
}
