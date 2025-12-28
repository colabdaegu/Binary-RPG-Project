using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitGameStop : MonoBehaviour
{
    // 닿을 시 게임 중단
    public string targetObjectName;

    void Start()
    {
        Time.timeScale = 1;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            Time.timeScale = 0;
        }
    }
}