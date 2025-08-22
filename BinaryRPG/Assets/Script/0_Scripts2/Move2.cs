using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    public float speed;
    public float jumppower;

    float vx = 0;
    bool leftFlag = false;  // 좌우 캐릭터 모습 제어
    bool pushFlag = false;  // 스페이스키를 누르고 있는지 여부
    bool jumpFlag = false;  // 점프 상태인지 여부
    bool groundFlag = false;    // 연속 점프 방지
    public string objectTriggerName; // 트리거 오브젝트(제외)

    Rigidbody2D rbody;
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void Update()
    {
        vx = 0;

        if (Input.GetKey("right"))
        {
            vx = speed;
            leftFlag = false;
        }

        if (Input.GetKey("left"))
        {
            vx = -speed;
            leftFlag = true;
        }

        if (Input.GetKey("space") && groundFlag)
        {
            if (pushFlag == false)  // 누르고 있지 않으면
            {
                jumpFlag = true;
                pushFlag = true;
            }
        }
        else
        {
            pushFlag = false;
        }
    }

    void FixedUpdate()
    {
        // 이동한다
        rbody.velocity = new Vector2(vx, rbody.velocity.y);
        this.GetComponent<SpriteRenderer>().flipX = leftFlag;
        if (jumpFlag)
        {
            jumpFlag = false;
            rbody.AddForce(new Vector2(0, jumppower), ForceMode2D.Impulse);
        }
    }

    // 트리거[바닥에 닿았는지]를 감지하여 연속 점프 방지
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name != objectTriggerName)     // 씬에 있는 트리거 오브젝트 제외
        {
            groundFlag = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name != objectTriggerName)
        {
            groundFlag = false;
        }
    }
}
