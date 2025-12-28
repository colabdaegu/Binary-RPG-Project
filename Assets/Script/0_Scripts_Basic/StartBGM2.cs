using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBGM2 : MonoBehaviour
{
    public AudioClip bgmClip; // 재생할 오디오 클립

    void Start()
    {
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = bgmClip;
        audioSource.Play();
    }

    void FixedUpdate()
    {
        float time = Time.time % 10f; // 10초 주기로 반복되게 함

        if (time == 2f)
        {
            //this.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
    }
}