using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox2 : MonoBehaviour
{
    public string mainName; // Main2

    // 자신 오브젝트를 제외한 나머지 프리팹 오브젝트들
    public string hideObjectName1;
    public string hideObjectName2;
    public string hideObjectName3;
    public string hideObjectName4;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == mainName)
        {
            // 정답일 시
            if (MainBossScripts.boxNum2 == MainBossScripts.decimalNum)
            {
                // 보스 HP -1
                MainBossScripts.bossLife -= 1;
                PVPStarting.isRight = true; // 정답 상태(BossTextScripts에서 사용)

                // 나머지 프리팹 오브젝트들 삭제
                GameObject hideObject1 = GameObject.Find(hideObjectName1);
                Destroy(hideObject1);
                GameObject hideObject2 = GameObject.Find(hideObjectName2);
                Destroy(hideObject2);
                if (MainBossScripts.bossLife <= 2)
                {
                    GameObject hideObject3 = GameObject.Find(hideObjectName3);
                    Destroy(hideObject3);
                }
                if (MainBossScripts.bossLife <= 1)
                {
                    GameObject hideObject4 = GameObject.Find(hideObjectName4);
                    Destroy(hideObject4);
                }
            }
            // 오답일 시
            else
            {
                // 주인공 HP -1
                PVPStarting.life -= 1;
                Main2HPEventScripts.HPEvent = true; // 오답 이벤트 활성화
            }
        }
    }
}