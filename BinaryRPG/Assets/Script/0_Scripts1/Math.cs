using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Math : MonoBehaviour
{
    // 주인공 HP 제어 오브젝트의 스크립트
    
    int life = 3;   // 주인공 최초 HP

    public string targetObjectName; // box(Clone)

    public string showObjectName1;  // 캔버스 라이프1 이미지
    public string showObjectName2;  // 캔버스 라이프2 이미지
    public string showObjectName3;  // 캔버스 라이프3 이미지

    GameObject showObject1; // 캔버스 라이프1 이미지
    GameObject showObject2; // 캔버스 라이프2 이미지
    GameObject showObject3; // 캔버스 라이프3 이미지

    public string sceneName;    // GameOver 씬으로

    public static bool lifeDownBGM = false;     // BGM 활상화 여부


    void Start()
    {
        showObject1 = GameObject.Find(showObjectName1); // 캔버스 라이프1 이미지 감지
        showObject2 = GameObject.Find(showObjectName2); // 캔버스 라이프2 이미지 감지
        showObject3 = GameObject.Find(showObjectName3); // 캔버스 라이프3 이미지 감지
    }

    void Update()
    {
        // 주인공 HP 실시간 업데이트
        if (life == 3)
        {
            showObject1.SetActive(true);
            showObject2.SetActive(true);
            showObject3.SetActive(true);
        }
        else if(life == 2)
        {
            showObject1.SetActive(true);
            showObject2.SetActive(true);
            showObject3.SetActive(false);
        }
        else if(life == 1)
        {
            showObject1.SetActive(true);
            showObject2.SetActive(false);
            showObject3.SetActive(false);
        }
        else if (life == 0)
        {
            showObject1.SetActive(false);
            showObject2.SetActive(false);
            showObject3.SetActive(false);

            // HP 0 도달 시 GameOver 씬으로 전환
            SceneManager.LoadScene(sceneName);
        }
    }

    // Collision = (HP +1)
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            Destroy(collision.gameObject);
        }
        life = life + 1;

        // HP 3 초과 불가
        if (life > 3)
        {
            life = 3;
        }
    }

    // Trigger = (HP -1)
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            Destroy(collision.gameObject);
        }
        life = life - 1;

        lifeDownBGM = true;
    }
}
