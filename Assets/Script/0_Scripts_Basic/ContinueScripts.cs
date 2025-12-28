using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueScripts : MonoBehaviour
{
    // 스테이지 클리어 씬에서 사용되는 스크립트

    public string showObjectName;     // 스템프
    GameObject showObject;

    public AudioClip bgmStamp;
    public AudioClip bgmWarp;

    public string sceneName;
    public string exitSceneName;

    void Start()
    {
        showObject = GameObject.Find(showObjectName);
        showObject.SetActive(false);

        Invoke("ClearStamp", 2f);

        if (ClickQuizMapChange.QuizMode == 1)
        {
            Invoke("LoadExitScene", 4f);
        }
        else
        {
            Invoke("WarpBGM", 4f);
            Invoke("LoadNextScene", 6f);
        }
    }
    

    void ClearStamp()
    {
        showObject.SetActive(true);

        AudioSource audioSourceStamp = gameObject.AddComponent<AudioSource>();
        audioSourceStamp.clip = bgmStamp;
        audioSourceStamp.Play();
    }

    void WarpBGM()
    {
        AudioSource audioSourceWarp = gameObject.AddComponent<AudioSource>();
        audioSourceWarp.clip = bgmWarp;
        audioSourceWarp.Play();
    }

    void LoadNextScene()
    {
        ClickQuizMapChange.QuizMode = 0;

        SceneManager.LoadScene(sceneName);
    }

    void LoadExitScene()
    {
        ClickQuizMapChange.QuizMode = 0;

        SceneManager.LoadScene(exitSceneName);
    }
}
