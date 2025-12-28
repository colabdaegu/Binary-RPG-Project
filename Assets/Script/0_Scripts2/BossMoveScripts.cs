using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMoveScripts : MonoBehaviour
{
    // 보스 X좌표 이동량
    public int moveX = 10;

    bool OneTime = true;    // 보스 HP가 2일 때 1회만
    bool OneTimes = true;   // 보스 HP가 1일 때 1회만

    public static bool bossJumpBGM = false;     // BGM 활상화 여부

    Rigidbody2D rbody;
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 보스 HP가 2일 때 한 번만
        if (MainBossScripts.bossLife == 2 && OneTime)
        {
            Invoke("MoveUp", 2f);   // 2초 후에 MoveUp 실행
            moveX = -moveX; // 보스 X좌표 이동량 반전
            Invoke("MoveLeftRight", 4f);    // 4초 후에 MoveLeftRight 실행

            OneTime = false;
        }
        // 보스 HP가 1일 때 한 번만
        else if (MainBossScripts.bossLife == 1 && OneTimes)
        {
            Invoke("MoveUp", 2f);   // 2초 후에 MoveUp 실행
            moveX = -moveX; // 보스 X좌표 이동량 반전
            Invoke("MoveLeftRight", 5f);    // 5초 후에 MoveLeftRight 실행

            OneTimes = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        rbody.velocity = Vector2.zero;  // 미끄러짐X
    }


    // 보스 공중 이동
    void MoveUp()
    {
        if (MainBossScripts.bossLife == 2)
        {
            rbody.velocity = new Vector2(0, 15);
        }
        else if(MainBossScripts.bossLife == 1)
        {
            rbody.velocity = new Vector2(0, 25);
        }

        bossJumpBGM = true;
    }

    // 보스 좌우 이동
    void MoveLeftRight()
    {
        rbody.velocity = new Vector2(moveX, 0);
    }
}
