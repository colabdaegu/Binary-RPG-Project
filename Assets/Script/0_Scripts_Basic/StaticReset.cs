using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticReset : MonoBehaviour
{
    // 중요 전역변수 리셋
    
    void Start()
    {
        PVPStarting.life = 3;
        MainBossScripts.bossLife = 3;
        //PVPStarting.doThrow = false;

        MainCharScripts.monsterPocket = true;

        BGMHit.gameStart = false;
        PVPStarting.doThrow = false;

        ClickStoryMode.storyModeEvent = false;
    }
}
