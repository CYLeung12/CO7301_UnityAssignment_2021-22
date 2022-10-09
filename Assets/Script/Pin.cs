using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pin : MonoBehaviour
{
    public Quaternion pinPosition;
    public Rigidbody rb;
    public Transform GameObject;

    private void Start()
    {
        pinPosition = rb.transform.rotation;
    }

    // private void Update()
    // {
    //     if (GameObject.transform.eulerAngles.x > -20f && GameObject.transform.eulerAngles.x <= 0f)
    //     {
    //         Debug.Log("HYE");
    //     }
    // }
}
