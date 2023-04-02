using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class GoalArea : MonoBehaviour
{

    public TextMeshPro pointsTMP;

    public float points;
    public Text pointsText;
    public Timer timer;

    public float initialPoints = 0;

    private bool scoreBoardOn = false;

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "GoalObj"){
            Debug.Log("Add points");
            addPoints();
        }
    }

    private void addPoints(int val=10){
        var tmp = int.Parse(pointsTMP.text) + val;
        Debug.Log(tmp);
        pointsTMP.text = tmp.ToString();
        pointsText.text = tmp.ToString();
    }

    void Start(){
        points = initialPoints;
        pointsText.text = points.ToString();
    }

    void update(){
        if(!timer.timerOn){
            scoreBoardOn = false;
            return;
        }
    }

}
