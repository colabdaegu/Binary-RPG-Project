using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScripts : MonoBehaviour
{
    public string targetObjectName;

    public GameObject newPrefab;

    // 생명력 카운트 오브젝트 위치
    public Transform mainBox;

    public static bool itemBGM = false;     // BGM 활상화 여부

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            // 닿을시 아이템 오브젝트 삭제
            Destroy(this.gameObject);

            Vector3 hpPlusCount = mainBox.transform.position + new Vector3(-2, 2, 0);
            // 카운트 프리팹을 통해 주인공 HP +1
            GameObject newObject = Instantiate(newPrefab, hpPlusCount, Quaternion.identity);

            itemBGM = true;
        }
    }
}