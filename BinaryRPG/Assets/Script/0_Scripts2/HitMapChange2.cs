using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitMapChange2 : MonoBehaviour
{
    // 포탈 가동
    public string sceneName;
    public string targetObjectName; // Main2

    public string bossObjectName;   // Boss

    public static bool portalBGM = false;     // BGM 활상화 여부

    void Start()
    {
        GameObject bossObject = GameObject.Find(bossObjectName);

        // 최초 실행 시 포탈 모습 숨김
        this.gameObject.SetActive(false);
        transform.position = bossObject.transform.position + new Vector3(0, -1.2f, 0);

        // 2초 후 Portal 실행
        Invoke("Portal", 2f);
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            portalBGM = true;

            // 씬 넘김
            SceneManager.LoadScene(sceneName);
        }
    }


    // 포탈 모습 보이게
    void Portal()
    {
        this.gameObject.SetActive(true);
    }
}
