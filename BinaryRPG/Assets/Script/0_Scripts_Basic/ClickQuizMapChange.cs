using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickQuizMapChange : MonoBehaviour
{
    // 화면 클릭 시 씬 이동(퀴즈 모드용)

    public string sceneName;

    // 퀴즈 모드 활성화 여부(0: 스토리 모드, 1: 퀴즈 모드)
    public static int QuizMode = 0;

    void OnMouseDown()
    {
        QuizMode = 1;

        SceneManager.LoadScene(sceneName);
    }
}
