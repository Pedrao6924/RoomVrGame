using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float time;
    public bool timerOn = false;

    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        timerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(timerOn){
            time -= Time.deltaTime;
            updateTimer(time);
        }else{
            time = 0;
            timerOn = false;
        }
    }

    void updateTimer(float currentTime){

        currentTime += 1;
        
        float min= Mathf.FloorToInt(currentTime / 60);
        float sec= Mathf.FloorToInt(currentTime % 60);

        if(sec == 0 && min == 0){
            timerOn = false;
        }
        timerText.text = string.Format("{0:00}:{1:00}", min, sec);
    }
}
