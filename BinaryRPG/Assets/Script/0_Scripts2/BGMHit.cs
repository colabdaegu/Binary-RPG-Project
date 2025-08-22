using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMHit : MonoBehaviour
{
    public string targetObjectName; // Main2

    public static bool gameStart = false;   // PVPStarting 스크립트에서 최초 '퀴즈 스크립트' 시작

    // bgm박스 오브젝트
    public string bgmBoxName;
    GameObject bgmBox;

    void Start()
    {
        // bgm박스 오브젝트 감지 및 최초 실행 시 숨김
        bgmBox = GameObject.Find(bgmBoxName);
        bgmBox.SetActive(false);
    }

    // 닿으면 BGM 재생
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            gameStart = true;

            bgmBox.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
