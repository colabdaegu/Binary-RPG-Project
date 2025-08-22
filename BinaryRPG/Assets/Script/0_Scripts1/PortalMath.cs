using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalMath : MonoBehaviour
{
    // 포탈 생성 제어 오브젝트의 스크립트

    int death = 0;  // 처치 몬스터 수
    public int howMuchToKill = 3;   // 처치해야 하는 몬스터 수
    public int quiz_HowMuchToKill = 10;     // 처치해야 하는 몬스터 수(퀴즈 모드 전용) [10 고정]

    public string targetObjectName; // box(Clone)

    // 포탈 오브젝트
    public string portalName;
    GameObject portal;

    public string wallObjectName;   // 몬스터 시체 담는 인큐베이터 오브젝트
    GameObject wallObject;
    public string quiz_WallObjectName;   // 몬스터 시체 담는 인큐베이터 오브젝트
    GameObject quiz_WallObject;

    public string prefabObjectName;     // 몬스터 시체 오브젝트

    void Start()
    {
        // 포탈 오브젝트 감지 및 최초 실행 시 숨김
        portal = GameObject.Find(portalName);
        portal.SetActive(false);

        wallObject = GameObject.Find(wallObjectName);    // 몬스터 시체 담는 인큐베이터 오브젝트 감지
        quiz_WallObject = GameObject.Find(quiz_WallObjectName);    // 몬스터 시체 담는 인큐베이터 오브젝트 감지(퀴즈 모드 전용)

        if (ClickQuizMapChange.QuizMode != 1)
        {
            quiz_WallObject.SetActive(false);
        }
        else
        {
            wallObject.SetActive(false);
        }
    }

    void Update()
    {
        if (ClickQuizMapChange.QuizMode != 1)
        {
            if (death == howMuchToKill)
            {
                StageClearEvent();

                Destroy(wallObject);    // 몬스터 시체 담는 인큐베이터 오브젝트 삭제
            }
        }
        else
        {
            if (death == quiz_HowMuchToKill)
            {
                StageClearEvent();

                Destroy(quiz_WallObject);    // 몬스터 시체 담는 인큐베이터 오브젝트 삭제(퀴즈 모드 전용)
            }
        }
    }

    // 처치 몬스터 수 +1
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            Destroy(collision.gameObject);
        }
        death = death + 1;

        // 포탈 활성화에 사용되는 몬스터 처치 수 달성 시 그 이상의 감지 중단
        if (ClickQuizMapChange.QuizMode != 1)
        {
            if (death > howMuchToKill)
            {
                death = howMuchToKill;
            }
        }
        else
        {
            if (death > quiz_HowMuchToKill)
            {
                death = quiz_HowMuchToKill;
            }
        }
    }


    void StageClearEvent()
    {
        GameObject prefabObject = GameObject.Find(prefabObjectName);    // 몬스터 시체 오브젝트 감지
        Destroy(prefabObject);  // 몬스터 시체 오브젝트 삭제

        MainCharScripts.monsterPocket = false;  // 몬스터 시체 오브젝트 더이상 화면에 표시X

        portal.SetActive(true);     // 포탈 활성화
    }
}