using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{

int score = 0;
GameObject[] pins;
[SerializeField] Text bowlingScore;

void Start()
{
    pins = GameObject.FindGameObjectsWithTag("Pin");
}


 
void Update()
{
    for (int i =0; i< pins.Length; i++)
    {
        if((pins[i].transform.eulerAngles.x >350 || pins[i].transform.eulerAngles.x <190) && pins[i].activeSelf)
        {
           score = 1 + score; 
        pins[i].SetActive(false);
        }
       bowlingScore.text = "Score: " + score.ToString(); 
    }
}

public void Reset()
{
    score = 0;
    bowlingScore.text = "Score: " + score.ToString(); 
}
}



