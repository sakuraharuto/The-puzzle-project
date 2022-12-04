using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePadController : MonoBehaviour
{
    [SerializeField] float lockDist;
    private void OnTriggerStay(Collider other) {
        if (other.tag == "key")
        {
            Transform cube = other.GetComponent<Transform>();
            float dist = Vector3.Distance(cube.position, transform.position);

            if (dist < lockDist)
            {
                cube.GetComponent<Rigidbody>().isKinematic = true;

                Debug.Log("One cube in place");
            }
        }
    }
}
