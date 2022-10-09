using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SkittlesReset : MonoBehaviour
{
    public Rigidbody rb;
    GameObject[] pins;
    Vector3 ballOriginal;
    Vector3[] pinsOriginalP;
    Quaternion pinsOriginalR;

void Start()
{
    pins = GameObject.FindGameObjectsWithTag("Pin");
    pinsOriginalR = pins[0].transform.rotation;
    pinsOriginalP = new Vector3[pins.Length];
    for (int i =0; i< pins.Length; i++)
    {
        pinsOriginalP[i] = pins[i].transform.position;
    }
    rb = GetComponent<Rigidbody>();
    ballOriginal = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
 }



public void Reset()
{
    for (int i =0; i< pins.Length; i++)
    {
         pins[i].SetActive(true);
        pins[i].transform.rotation = pinsOriginalR;
        pins[i].transform.position = pinsOriginalP[i];
        pins[i].GetComponent<Rigidbody>().velocity = Vector3.zero;
        pins[i].GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
    rb.velocity = Vector3.zero;
    rb.angularVelocity = Vector3.zero;
    gameObject.transform.position = ballOriginal;
    

}

}
