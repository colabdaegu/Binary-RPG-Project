using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaitSceneChange : MonoBehaviour
{
    // 기다리면 씬 자동 이동
    public string sceneName;

    public float waitSec = 5;

    void Start()
    {
        Invoke("SceneChange", waitSec);
    }

    void SceneChange()
    {
        SceneManager.LoadScene(sceneName);
    }
}
