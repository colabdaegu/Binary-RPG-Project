using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Say_Main : MonoBehaviour
{
    // 주인공 말풍선 등장 시기(컴플리트)

    public string sayMainObjectName;
    GameObject sayMainObject;

    bool OneTime = true;

    void Start()
    {
        sayMainObject = GameObject.Find(sayMainObjectName);
        sayMainObject.SetActive(false);
    }

    void Update()
    {
        if (ClickQuizMapChange.QuizMode != 1 && OneTime)
        {
            if (MainCharScripts.monsterPocket == false)
            {
                Invoke("ComeOutSaying", 1f);

                OneTime = false;
            }
        }
    }
    

    void ComeOutSaying()
    {
        sayMainObject.SetActive(true);
    }
}
