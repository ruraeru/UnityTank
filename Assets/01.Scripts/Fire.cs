using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject firePosition;
    public GameObject bullet;
    public GameObject arrow;
    public GameManagerLogic manager;
    public int bulletCount;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Object obj = Instantiate(bullet, firePosition.transform.position, firePosition.transform.rotation);
            bulletCount++;
            manager.GetBullet(bulletCount);
            Destroy(obj, 5.5f);
            //bulletCount--;
            //manager.GetBullet(bulletCount);
        }
        else if(Input.GetMouseButtonDown(1))
        {
            Object obj = Instantiate(arrow, firePosition.transform.position, firePosition.transform.rotation);
        }
    }
}
