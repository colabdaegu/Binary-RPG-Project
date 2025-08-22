using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main2HPEventScripts : MonoBehaviour
{
    public static bool HPEvent = false; // 오답 시 주인공 공격하는 이벤트 활성화 여부 static

    public string showObjectName;   // Main2HPEvent
    GameObject showObject;

    void Start()
    {
        // 최초 실행 시 Main2HPEvent의 모습을 숨김
        showObject = GameObject.Find(showObjectName);
        showObject.SetActive(false);
    }

    void Update()
    {
        // 오답 오브젝트 선택 시
        if (HPEvent)
        {
            // Main2HPEvent 보이게
            showObject.SetActive(true);
            Invoke("EventHide", 0.2f);  // 0.2초 후 EventHide 실행(Main2HPEvent 삭제)
        }
    }


    // Main2HPEvent 삭제 및 이벤트 비활성화
    void EventHide()
    {
        showObject.SetActive(false);
        HPEvent = false;
    }
}
