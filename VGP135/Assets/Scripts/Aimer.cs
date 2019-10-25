using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aimer : MonoBehaviour
{
    public Ball ball;
    public Quaternion QuatTest;
    //Quaternion nothing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ball.isDragging)
        {
            transform.position = ball.transform.position;
            QuatTest = transform.localRotation;
        }
    }
}
