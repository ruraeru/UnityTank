using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    float x,y,z;
    Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * 10;
        y = Input.GetAxisRaw("Jump") * Time.deltaTime * 10;
        z = Input.GetAxis("Vertical") * Time.deltaTime * 10;

        transform.Rotate(x, y, z);
    }
}
