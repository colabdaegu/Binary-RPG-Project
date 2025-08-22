using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitBGMStart : MonoBehaviour
{
    // 기다렸다가 BGM 오브젝트 생성

    public string bgmObjectName;
    GameObject bgmObject;

    void Start()
    {
        bgmObject = GameObject.Find(bgmObjectName);
        bgmObject.SetActive(false);

        Invoke("BGMOn", 1f);
    }

    void BGMOn()
    {
        bgmObject.SetActive(true);
    }
}
