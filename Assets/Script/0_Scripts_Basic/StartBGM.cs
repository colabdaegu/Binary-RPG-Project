using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBGM : MonoBehaviour
{
    public AudioClip bgmClip; // 재생할 오디오 클립

    void Start()
    {
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = bgmClip;
        audioSource.Play();
    }
}
