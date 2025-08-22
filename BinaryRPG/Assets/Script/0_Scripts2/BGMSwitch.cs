using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMSwitch : MonoBehaviour
{
    public AudioClip bgmClip; // 재생할 오디오 클립

    void Start()
    {
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = bgmClip;
        audioSource.Play();

        audioSource.loop = true;    // 루핑: 반복 재생
    }


    void Update()
    {
        // 배경음 중단
        if (MainBossScripts.bossLife == 0 || PVPStarting.life == 0)
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}
