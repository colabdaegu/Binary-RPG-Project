using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTrigger : MonoBehaviour
{
    public string targetObjectName;

    void OnTriggerStay2D(Collider2D collision)
    {
        // 주인공(타겟)이랑 닿을 시 [불] 공격 모션 삭제
        if (collision.gameObject.name == targetObjectName)
        {
            Destroy(this.gameObject);
        }
    }
}