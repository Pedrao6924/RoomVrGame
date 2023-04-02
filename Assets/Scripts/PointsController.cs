using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsController : MonoBehaviour
{

    public float points;
    public bool scoreBoardOn = false;
    public Text pointsText;

    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        pointsText.text = points.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
