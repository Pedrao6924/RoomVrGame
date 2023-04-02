using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalObjects : MonoBehaviour
{

    public GameObject obj;
    public Vector3 spawnPosition;

    void OnTriggerEnter(Collider other) {
        Debug.Log("Enter");
        if(other.tag == "LeftHand" || other.tag == "RightHand"){
            spawnObject();
        }
    }

    private void spawnObject(){
        Instantiate(obj, spawnPosition, Quaternion.identity);
    }
}
