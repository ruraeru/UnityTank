using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerLogic : MonoBehaviour
{
    public Text BulletCountText;

    public void GetBullet(int count)
    {
        BulletCountText.text = count.ToString();
    }


}
