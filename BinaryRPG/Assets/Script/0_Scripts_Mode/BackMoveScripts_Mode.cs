using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMoveScripts_Mode : MonoBehaviour
{
    // 이미지 움직임(Mode씬 전용)

    private bool moveNow = true;


    bool OneTime = true;

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

        if (ClickStoryMode.storyModeEvent && OneTime)
        {
            Invoke("MoveStop", 6.1f);

            OneTime = false;
        }
    }



    void MoveStop()
    {
        moveNow = false;
    }
}
