using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour
{
    public float intialForce = 9.8f;
    public Rigidbody rb;
    public Vector3 originalPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        originalPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Bumper Right")
        {
            
            rb.AddForce(Vector3.left * intialForce * 0.5f, ForceMode.Impulse);
        }
        else if (other.gameObject.name == "Bumper Left")
        {
            rb.AddForce(Vector3.right * intialForce * 0.5f, ForceMode.Impulse);
        }
        // else if (other.gameObject.name == "Bumper Back")
        // {
        //     rb.velocity = Vector3.zero;
        //     rb.angularVelocity = Vector3.zero;
        //     gameObject.transform.position = originalPosition;
        // }
    }
}
