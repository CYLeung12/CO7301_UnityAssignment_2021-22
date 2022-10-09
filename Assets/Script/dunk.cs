using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class dunk : MonoBehaviour
{
    
    public int score;
     [SerializeField] Text scoreText;

    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score.ToString(); 
    }



    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "basketball")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            score = 1+ score;
            scoreText.text = "Score: " + score.ToString(); 
        }
    }

    public void Reset()
    {
        score = 0;
        scoreText.text = "Score: " + score.ToString(); 
    }

    
}
