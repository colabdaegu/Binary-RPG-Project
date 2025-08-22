using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScripts2 : MonoBehaviour
{
    public string targetObjectName2; // Main2
    public string targetObjectName8; // Main8
    public string targetObjectName16; // Main16

    public static bool itemBGM = false;     // BGM 활상화 여부

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == targetObjectName2 || collision.gameObject.name == targetObjectName8 || collision.gameObject.name == targetObjectName16)
        {
            // 주인공이 이 오브젝트(아이템) 먹을 시 오브젝트 삭제 및 주인공 HP +1
            Destroy(this.gameObject);
            PVPStarting.life += 1;

            itemBGM = true;
        }
    }
}
