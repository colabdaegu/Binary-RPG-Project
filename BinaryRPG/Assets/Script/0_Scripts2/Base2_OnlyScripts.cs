using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base2_OnlyScripts : MonoBehaviour
{
    // 보스 사망 시 포탈로 갈 수 있는 계단 생성

    public string showBlockObject1Name;
    GameObject showBlockObject1;
    public string showBlockObject2Name;
    GameObject showBlockObject2;

    void Start()
    {
        showBlockObject1 = GameObject.Find(showBlockObject1Name);
        showBlockObject1.SetActive(false);
        showBlockObject2 = GameObject.Find(showBlockObject2Name);
        showBlockObject2.SetActive(false);
    }

    void Update()
    {
        if(MainBossScripts.bossLife == 0)
        {
            showBlockObject1.SetActive(true);
            showBlockObject2.SetActive(true);
        }
    }
}
