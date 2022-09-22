using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankRotate : MonoBehaviour
{
    float r;
    public int RotateSpeed;
    void Start()
    {
        r = 0;
    }

    void Update()
    {
        r = Input.GetAxis("Mouse X") * Time.deltaTime * RotateSpeed;
        
        transform.Rotate(0, r, 0);
    }
}
