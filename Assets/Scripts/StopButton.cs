using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopButton : MonoBehaviour
{
     public ControllTimer timerController;
   
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "LeftHand" || other.tag == "RightHand"){
            timerController.stopTimer();
        }
    }
}
