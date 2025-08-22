using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMArea : MonoBehaviour
{
    public AudioClip bgmClipQuizStart; // 몬스터와의 조우(퀴즈 스크립트) 오디오 클립
    public AudioClip bgmClipItems; // 아이템(프리팹) 오디오 클립
    public AudioClip bgmClipPortal; // 포탈 오디오 클립
    public AudioClip bgmClipMagicAttack; // 주인공의 마법 공격(정답) 오디오 클립
    public AudioClip bgmClipFireAttack; // 몬스터의 화염 공격(오답) 오디오 클립
    public AudioClip bgmClipLifeDown; // 주인공 HP -1(오답) 오디오 클립
    public AudioClip bgmClipDeathMonster; // 몬스터 사망 오디오 클립


    void Update()
    {
        if (PVPStart.quizStartBGM)   // 몬스터와의 조우(퀴즈 스크립트) 오디오 재생 여부
        {
            AudioSource audioSourceQuizStart = gameObject.AddComponent<AudioSource>();
            audioSourceQuizStart.clip = bgmClipQuizStart;
            audioSourceQuizStart.Play();

            PVPStart.quizStartBGM = false;
        }

        if (ItemScripts.itemBGM)   // 아이템(프리팹) 오디오 재생 여부
        {
            AudioSource audioSourceItems = gameObject.AddComponent<AudioSource>();
            audioSourceItems.clip = bgmClipItems;
            audioSourceItems.Play();

            ItemScripts.itemBGM = false;
        }

        if (HitMapChange.portalBGM)   // 포탈 오디오 재생 여부
        {
            AudioSource audioSourcePortal = gameObject.AddComponent<AudioSource>();
            audioSourcePortal.clip = bgmClipPortal;
            audioSourcePortal.Play();

            HitMapChange.portalBGM = false;
        }

        if (MainCharScripts.magicAttackBGM)   // 주인공의 마법 공격(정답) 오디오 재생 여부
        {
            AudioSource audioSourceMagicAttack = gameObject.AddComponent<AudioSource>();
            audioSourceMagicAttack.clip = bgmClipMagicAttack;
            audioSourceMagicAttack.Play();

            MainCharScripts.magicAttackBGM = false;
        }

        if (MainCharScripts.fireAttackBGM)   // 몬스터의 화염 공격(오답) 오디오 재생 여부
        {
            AudioSource audioSourceFireAttack = gameObject.AddComponent<AudioSource>();
            audioSourceFireAttack.clip = bgmClipFireAttack;
            audioSourceFireAttack.Play();

            MainCharScripts.fireAttackBGM = false;
        }

        if (Math.lifeDownBGM)   // 주인공 HP -1(오답) 오디오 재생 여부
        {
            AudioSource audioSourceLifeDown = gameObject.AddComponent<AudioSource>();
            audioSourceLifeDown.clip = bgmClipLifeDown;
            audioSourceLifeDown.Play();

            Math.lifeDownBGM = false;
        }

        if (MainCharScripts.deathMonsterBGM)   // 몬스터 사망 오디오 재생 여부
        {
            AudioSource audioSourceDeathMonster = gameObject.AddComponent<AudioSource>();
            audioSourceDeathMonster.clip = bgmClipDeathMonster;
            audioSourceDeathMonster.Play();

            MainCharScripts.deathMonsterBGM = false;
        }
    }
}

