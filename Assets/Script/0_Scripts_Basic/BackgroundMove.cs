using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    // 이미지 움직임

    private bool moveNow = true;

    Rigidbody2D rbody;
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();

        Invoke("MoveStop", 60f);
    }

    void FixedUpdate()
    {
        if (moveNow)
        {
            rbody.velocity = new Vector2(0.3f, 0);
        }
        else
        {
            rbody.velocity = Vector2.zero;
        }
    }


    void MoveStop()
    {
        moveNow = false;
    }
}
