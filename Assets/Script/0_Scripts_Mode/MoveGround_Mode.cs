using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGround_Mode : MonoBehaviour
{
    // 땅 움직임

    private int canMove = 2;    // (2: X,Y 양방향, 1: X만, 0: 정지)

    Rigidbody2D rbody;
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();

        Invoke("StopMovingY", 4f);
        Invoke("StopMovingAll", 6.1f);
    }

    void FixedUpdate()
    {
        if (canMove == 2)
        {
            rbody.velocity = new Vector2(0.9f, 1.4f);
        }
        else if (canMove == 1)
        {
            rbody.velocity = new Vector2(0.9f, 0);
        }
        else
        {
            rbody.velocity = new Vector2(0, 0);
        }
        
    }


    void StopMovingY()
    {
        canMove = 1;
    }

    void StopMovingAll()
    {
        canMove = 0;
    }
}

