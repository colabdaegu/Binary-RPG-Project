using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageClear : MonoBehaviour
{
    // 보스 처치 후 클리어 BGM 재생


    public static bool stageClearBGM = false;     // BGM 활상화 여부

    // 한 번만 실행
    bool OneTime = true;


    void Update()
    {
        if (MainBossScripts.bossLife == 0 && OneTime)
        {
            OneTime = false;

            // 클리어 기념 BGM
            Invoke("ClearBGM", 2.5f);
        }
    }


    void ClearBGM()
    {
        stageClearBGM = true;
    }
}
