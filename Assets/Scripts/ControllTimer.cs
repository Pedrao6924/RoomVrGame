using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControllTimer : MonoBehaviour
{

    public Timer timer;
    public TextMeshPro pointsTMP;
    public Text pointsText;

    public void startTimer(){
        timer.time = 120;
        timer.timerOn = true;
        pointsTMP.text = "0000";
        pointsText.text = "0000";

    }

    public void stopTimer(){
         timer.timerOn = false;
    }

}
