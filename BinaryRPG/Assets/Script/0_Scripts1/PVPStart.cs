using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PVPStart : MonoBehaviour
{
    // 씬 시작 시 전체 스크립트 및 오브젝트 제어(몬스터 시점)
    public string targetObjectName;     // 주인공

    public bool move = true;     // 몬스터 움직임 제어
    //public float moveSec = 4;  // 몬스터 움직이는 시간
    public float moveNum;    // 몬스터 움직임 지정

    public string objectTriggerName; // 트리거 오브젝트

    // 주인공 텍스트 틀[박스]
    MainBoxScripts mainBoxScripts;
    public string mainBoxObjectName;

    // 주인공 입력 텍스트
    MainTextScripts mainTextScripts;
    public string mainTextObjectName;

    // 주인공 움직임 제한(버그 방지용) 오브젝트
    public Transform bugFixTransform;


    public static bool quizStartBGM = false;     // BGM 활상화 여부

    Rigidbody2D rbody;
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();

        // 주인공 텍스트 틀[박스] 감지
        GameObject boxOption = GameObject.Find(mainBoxObjectName);
        mainBoxScripts = boxOption.GetComponent<MainBoxScripts>();

        // 주인공 입력 텍스트 감지
        GameObject mainTextBoxObject = GameObject.Find(mainTextObjectName);
        mainTextScripts = mainTextBoxObject.GetComponent<MainTextScripts>();
    }

    void FixedUpdate()
    {
        // 몬스터 움직임 활성화
        if (move)
        {
            rbody.velocity = new Vector2(moveNum, 0); // 거리만큼 이동
        }
        // 몬스터 움직임 비활성화
        else
        {
            rbody.velocity = Vector2.zero;  // 미끄러짐X
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        // 주인공과 몬스터 닿을 시 [퀴즈 스크립트] 활성화
        if (collider.gameObject.name == targetObjectName)
        {
            // 퀴즈 스크립트 영역

            // 몬스터 움직임 비활성화
            move = false;

            mainBoxScripts.enabled = true;      // 주인공 텍스트 틀[박스] 스크립트 활성화
            mainTextScripts.enabled = true;     // 주인공 입력 텍스트 스크립트 활성화

            quizStartBGM = true;

            bugFixTransform.transform.position = MainMoveControl.MainTransform.transform.position;
        }
        // 트리거 오브젝트와 닿을 시 반대 방향으로 움직임
        if (collider.gameObject.name == objectTriggerName)
        {
            moveNum *= -1;
        }
    }
}
