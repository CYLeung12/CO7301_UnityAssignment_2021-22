using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTowerGame : MonoBehaviour
{
    public GameObject timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void startButtonClicked()
    {
        if (timer.activeInHierarchy == true)
            timer.SetActive(false);
        else
            timer.SetActive(true);
    }

}
