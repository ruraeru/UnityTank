using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Transform ball;
    void Start()
    {
        ball = GetComponent<BallMove>().transform;
    }
    void LateUpdate()
    {
       
    }

}
