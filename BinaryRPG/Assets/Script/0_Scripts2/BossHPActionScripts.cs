using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHPActionScripts : MonoBehaviour
{
    // 보스의 체력이 2 남았을 때 나타날 오브젝트
    public string bossHP2ActionName;
    GameObject bossHP2Action;

    // 보스의 체력이 1 남았을 때 나타날 오브젝트
    public string bossHP1ActionName;
    GameObject bossHP1Action;

    void Start()
    {
        bossHP2Action = GameObject.Find(bossHP2ActionName);
        bossHP2Action.SetActive(false);

        bossHP1Action = GameObject.Find(bossHP1ActionName);
        bossHP1Action.SetActive(false);
    }

    void Update()
    {
        if (MainBossScripts.bossLife <= 2)
        {
            // 보스 체력이 2가 되면 보스 위치에 데미지 오브젝트 생성
            bossHP2Action.transform.position = transform.position + new Vector3(0f, -0f, -4f);
            bossHP2Action.SetActive(true);
        }
        if(MainBossScripts.bossLife <= 1)
        {
            // 보스 체력이 1이 되면 보스 위치에 데미지 오브젝트 추가 생성
            bossHP1Action.transform.position = transform.position + new Vector3(0f, -0f, -5f);
            bossHP1Action.SetActive(true);
        }
        if (MainBossScripts.bossLife == 0)
        {
            // 보스 체력이 0이 되면 '보스 삭제 & 데미지 오브젝트 전체 삭제'
            Destroy(this.gameObject);
            bossHP2Action.SetActive(false);
            bossHP1Action.SetActive(false);
        }
    }
}
