using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotate : MonoBehaviour
{
    float r;
    void Start()
    {
        r = 0;
    }

    // Update is called once per frame
    void Update()
    {
        r = Input.GetAxisRaw("Mouse ScrollWheel") * 100;
        transform.Rotate(r, 0, 0);
    }
}
