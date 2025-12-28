using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainTrigger : MonoBehaviour
{
    // 트리거 영역에 닿을 시 주인공 캐릭터 재배치

    public string targetObjectName;

    Rigidbody2D rbody;
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            // 최초 카메라에서 사라지기 직전 X좌표로 이동
            this.transform.position = new Vector3(TriggerSave.triggerX - 1f, this.transform.position.y, this.transform.position.z);
            
            // 회전 기본으로 설정
            this.transform.rotation = Quaternion.identity;
            
            // X좌표 미끄러짐 중지
            rbody.velocity = new Vector2(0, rbody.velocity.y);
        }
    }
}