using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMove : MonoBehaviour
{
    float x, y, z;
    public int moveSpeed;
    void Start()
    {
        x = 0;
        y = 0;
        z = 0;
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * moveSpeed;
        z = Input.GetAxisRaw("Vertical") * Time.deltaTime * moveSpeed;
        y = Input.GetAxisRaw("Jump") * Time.deltaTime  * moveSpeed;
        transform.Translate(x, y, z);       
    }
}
