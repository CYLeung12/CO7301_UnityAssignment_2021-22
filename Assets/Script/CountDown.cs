using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public float currentTime = 60f;
    public GameObject gb;
    [SerializeField] Text countdownText;
    GameObject[] cubes;

    
        void Start(){
            gb.SetActive(false);
            cubes = GameObject.FindGameObjectsWithTag("TowerCube");
        }

        void Update(){
            currentTime -= 1 * Time.deltaTime;
            countdownText.text = "You still have: " + currentTime.ToString("0") + "s";
            if(currentTime <=0){
                countdownText.color = Color.red;
                countdownText.text = "Time is up! Please try again!";
                for (int i =0; i< cubes.Length; i++)
             {
        cubes[i].SetActive(false);
             }
            }
            else{
                countdownText.color = Color.white;
            }
        }

        public void reset(){
            currentTime = 60f;
        }
    
}
