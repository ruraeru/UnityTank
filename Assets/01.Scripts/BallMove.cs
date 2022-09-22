using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public int moveSpeed = 30;
    public float jumpPower = 30;
    bool isJump = true;
    Rigidbody rigid;

    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * moveSpeed;
        float z = Input.GetAxisRaw("Vertical") * Time.deltaTime * moveSpeed;
        rigid.AddForce(x, 0, z, ForceMode.Impulse);
    }

    void Update()
    {
        if(Input.GetButtonDown("Jump") && !isJump)
        {
            isJump = true;
            rigid.AddForce(0, jumpPower, 0, ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            isJump = false;
        }
    }
}
