using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryModeScripts : MonoBehaviour
{
    // 스토리모드 버튼 누를 시 실행

    public string groundObjectName;
    GameObject groundObject;
    public string mainObjectName;
    GameObject mainObject;

    public AudioClip bgmClipItems; // 오디오 클립
    AudioSource audioSourceItems;

    public string text1ObjectName;
    GameObject text1Object;
    public string text2ObjectName;
    GameObject text2Object;
    public string text3ObjectName;
    GameObject text3Object;

    public string portalObjectName;
    GameObject portalObject;

    public string portalObject2Name;
    GameObject portalObject2;
    public string portalObject3Name;
    GameObject portalObject3;
    public string portalObject4Name;
    GameObject portalObject4;
    public string portalObject5Name;
    GameObject portalObject5;

    public string sceneName;

    bool OneTime = true;


    void Start()
    {
        groundObject = GameObject.Find(groundObjectName);
        groundObject.SetActive(false);
        mainObject = GameObject.Find(mainObjectName);
        mainObject.SetActive(false);

        audioSourceItems = gameObject.AddComponent<AudioSource>();
        audioSourceItems.clip = bgmClipItems;
        text1Object = GameObject.Find(text1ObjectName);
        text1Object.SetActive(false);
        text2Object = GameObject.Find(text2ObjectName);
        text2Object.SetActive(false);
        text3Object = GameObject.Find(text3ObjectName);
        text3Object.SetActive(false);

        portalObject = GameObject.Find(portalObjectName);
        portalObject.SetActive(false);

        portalObject2 = GameObject.Find(portalObject2Name);
        portalObject2.SetActive(false);
        portalObject3 = GameObject.Find(portalObject3Name);
        portalObject3.SetActive(false);
        portalObject4 = GameObject.Find(portalObject4Name);
        portalObject4.SetActive(false);
        portalObject5 = GameObject.Find(portalObject5Name);
        portalObject5.SetActive(false);
    }

    void Update()
    {
        if (ClickStoryMode.storyModeEvent && OneTime)
        {
            StoryEvent();

            OneTime = false;
        }
    }


    void StoryEvent()
    {
        groundObject.SetActive(true);
        mainObject.SetActive(true);

        Invoke("BGMOn", 1f);

        Invoke("PortalOn", 6f);

        Invoke("PortalSubOn2", 8f);
        Invoke("PortalSubOn3", 9f);
        Invoke("PortalSubOn4", 9.5f);
        Invoke("PortalSubOn5", 10f);

        Invoke("GameSceneStart", 12f);
    }


    void BGMOn()
    {
        audioSourceItems.Play();

        text1Object.SetActive(true);
    }

    void PortalOn()
    {
        portalObject.SetActive(true);
        audioSourceItems.Stop();

        text1Object.SetActive(false);
        text2Object.SetActive(true);
    }

    void PortalSubOn2()
    {
        portalObject2.SetActive(true);
    }
    void PortalSubOn3()
    {
        portalObject3.SetActive(true);
        text3Object.SetActive(true);
    }
    void PortalSubOn4()
    {
        portalObject4.SetActive(true);
    }
    void PortalSubOn5()
    {
        portalObject5.SetActive(true);
    }

    void GameSceneStart()
    {
        SceneManager.LoadScene(sceneName);
    }
}
