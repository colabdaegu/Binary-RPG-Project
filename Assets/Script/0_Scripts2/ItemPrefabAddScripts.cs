using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPrefabAddScripts : MonoBehaviour
{
    public GameObject newPrefab;

    public float randomNum = 30;

    void FixedUpdate()
    {
        // 스크립트 활성화 기준으로 20초, 60초 후에 프리팹 오브젝트(아이템) 생성
        Invoke("CreatePrefab", 20);
        Invoke("CreatePrefab", 60);

        // 이후 스크립트 종료
        this.enabled = false;
    }


    void CreatePrefab()
    {
        // 이 오브젝트의 위치 저장 및 해당 위치 기준으로 X좌표 좌우로 랜덤 오브젝트 생성
        Vector3 newPos = this.transform.position;
        newPos.x += Random.Range(-randomNum, randomNum);
        newPos.y += 5;

        GameObject newGameObject = Instantiate(newPrefab, newPos, Quaternion.identity);
        newGameObject.transform.position = newPos;
    }
}
