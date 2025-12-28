using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeReset : MonoBehaviour
{
    // 모드 설정 리셋(타이틀 화면)

    void Start()
    {
        ClickQuizMapChange.QuizMode = 0;
    }
}
