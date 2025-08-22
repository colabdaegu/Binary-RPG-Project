using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMoveControl : MonoBehaviour
{
    // 주인공 이동 활성화 상태 제어
    public static Rigidbody2D MainTransform;

    public string targetObjectName1;
    public string targetObjectName2;
    public string targetObjectName3;
    public string targetObjectName4;
    public string targetObjectName5;
    public string targetObjectName6;
    public string targetObjectName7;
    public string targetObjectName8;
    public string targetObjectName9;
    public string targetObjectName10;

    Rigidbody2D rbody;
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();

        MainTransform = GetComponent<Rigidbody2D>();
        MainTransform.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // 몬스터랑 닿을 시 이동 제한(몬스터 개별 추가)
        if (collision.gameObject.name == targetObjectName1 || collision.gameObject.name == targetObjectName2 || collision.gameObject.name == targetObjectName3 || collision.gameObject.name == targetObjectName4 || collision.gameObject.name == targetObjectName5 || collision.gameObject.name == targetObjectName6 || collision.gameObject.name == targetObjectName7 || collision.gameObject.name == targetObjectName8 || collision.gameObject.name == targetObjectName9 || collision.gameObject.name == targetObjectName10)
        {
            gameObject.GetComponent<Move>().enabled = false;
            rbody.velocity = Vector2.zero;  // 미끄러짐X
        }
        else
        {
            gameObject.GetComponent<Move>().enabled = true;
        }
    }
}
