////code adapted from Tutorial - Introducing the MockHMDFile, n.d.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
public class HMDInfoManager : MonoBehaviour
{
 // Start is called before the first frame update
 void Start()
 {
 if(!XRSettings.isDeviceActive) Debug.Log("No headset connected");
 else if (XRSettings.isDeviceActive && (XRSettings.loadedDeviceName == "Mock HMD" ||
 XRSettings.loadedDeviceName == "MockHMD Display"))
 {
 Debug.Log("Using Mock HMD");
 }
 else Debug.Log("Headset being used is " + XRSettings.loadedDeviceName);
 }
 // Update is called once per frame
 void Update()
 {
 
 }
}

//end of adapted code