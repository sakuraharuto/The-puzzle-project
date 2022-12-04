using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPush : MonoBehaviour
{   
    [SerializeField] float pushForceMagnitude;


    private void OnControllerColliderHit(ControllerColliderHit hit) 
    {
        Rigidbody rb = hit.collider.attachedRigidbody;


        if (rb != null && !rb.isKinematic)
        {   
            /*
            Vector3 forceDir = hit.gameObject.transform.position - transform.position;
            forceDir.y = 0;
            forceDir.Normalize();
            */

            //rb.AddForceAtPosition(forceDir * pushForceMagnitude, transform.position, ForceMode.Impulse);
            //rb.AddForce(forceDir * pushForceMagnitude);
            rb.AddForce(hit.moveDirection * pushForceMagnitude);
        }
    }
}
