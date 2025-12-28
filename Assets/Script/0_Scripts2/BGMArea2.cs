using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMArea2 : MonoBehaviour
{
    public AudioClip bgmClipItems; // 아이템(프리팹) 오디오 클립
    public AudioClip bgmClipPortal; // 포탈 오디오 클립
    public AudioClip bgmClipBossJump; // 보스 점프 오디오 클립
    public AudioClip bgmClipBossEvent; // 보스 퀴즈 오브젝트 오디오 클립
    public AudioClip bgmClipStageClear; // 클리어 기념 오디오 클립


    void Update()
    {
        if (ItemScripts2.itemBGM)   // 아이템(프리팹) 오디오 재생 여부
        {
            AudioSource audioSourceItems = gameObject.AddComponent<AudioSource>();
            audioSourceItems.clip = bgmClipItems;
            audioSourceItems.Play();

            ItemScripts2.itemBGM = false;
        }

        if (HitMapChange2.portalBGM)   // 포탈 오디오 재생 여부
        {
            AudioSource audioSourcePortal = gameObject.AddComponent<AudioSource>();
            audioSourcePortal.clip = bgmClipPortal;
            audioSourcePortal.Play();

            HitMapChange2.portalBGM = false;
        }

        if (BossMoveScripts.bossJumpBGM)   // 보스 점프 오디오 재생 여부
        {
            AudioSource audioSourceBossJump = gameObject.AddComponent<AudioSource>();
            audioSourceBossJump.clip = bgmClipBossJump;
            audioSourceBossJump.Play();

            BossMoveScripts.bossJumpBGM = false;
        }

        if (MainBossScripts.bossEventBGM)   // 보스 퀴즈 오브젝트 오디오 재생 여부
        {
            AudioSource audioSourceBossEvent = gameObject.AddComponent<AudioSource>();
            audioSourceBossEvent.clip = bgmClipBossEvent;
            audioSourceBossEvent.Play();

            MainBossScripts.bossEventBGM = false;
        }


        if (StageClear.stageClearBGM)   // 클리어 기념 오디오 재생 여부
        {
            AudioSource audioSourceStageClear = gameObject.AddComponent<AudioSource>();
            audioSourceStageClear.clip = bgmClipStageClear;
            audioSourceStageClear.Play();

            StageClear.stageClearBGM = false;
        }
    }
}

