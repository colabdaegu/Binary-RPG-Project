using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneScripts01 : MonoBehaviour
{
    public static Vector3 currentPosition01;    // 오브젝트 위치 지정 static

    public string mainName; // Main2

    void Update()
    {
        currentPosition01 = transform.position; // 변수에 위치 저장(TextScripts01에서 사용)
    }

    // 주인공이랑 닿으면 이 오브젝트 삭제
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == mainName)
        {
            this.enabled = false;
        }
    }
}