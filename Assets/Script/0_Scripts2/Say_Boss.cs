using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Say_Boss : MonoBehaviour
{
    // 보스 말풍선 등장 시기

    public string sayBossObjectName;
    GameObject sayBossObject;

    void Start()
    {
        sayBossObject = GameObject.Find(sayBossObjectName);
        sayBossObject.SetActive(false);

        if (ClickQuizMapChange.QuizMode != 1)
        {
            Invoke("ComeOutSaying", 1f);
        }
    }

    void ComeOutSaying()
    {
        sayBossObject.SetActive(true);
    }
}
