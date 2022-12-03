using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPush : MonoBehaviour
{   
    [SerializeField] float pushForceMagnitude;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnControllerColliderHit(ControllerColliderHit hit) 
    {
        Rigidbody rb = hit.collider.attachedRigidbody;


        if (rb != null)
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
