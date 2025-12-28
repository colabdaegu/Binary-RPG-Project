using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabBoxScripts : MonoBehaviour
{
    // 프리팹 박스 오브젝트 전체 적용 스크립트
    
    public string noTouchObjectName;    // Boss
    public string mainName; // Main2
    public string FirstObjectName;  // firstBox

    Rigidbody2D rbody;
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Main2 또는 firstBox 오브젝트에 닿았을 시 삭제
        if (collision.gameObject.name == mainName || collision.gameObject.name == FirstObjectName)
        {
            Destroy(this.gameObject);
        }
        // 보스를 제외한 모든 오브젝트에 대해
        if (collision.gameObject.name != noTouchObjectName)
        {
            rbody.velocity = Vector2.zero;  // 미끄러짐X
        }
    }
}