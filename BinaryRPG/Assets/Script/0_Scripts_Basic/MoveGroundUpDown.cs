using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGroundUpDown : MonoBehaviour
{
    // 지형물 위아래로 움직임
    public float move = 3;

    public string targetObjectName; // 트리거 오브젝트

    Rigidbody2D rbody;
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rbody.velocity = new Vector2(0, move);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            move *= -1;
        }
    }
}
