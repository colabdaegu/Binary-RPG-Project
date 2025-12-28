using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickStoryMode : MonoBehaviour
{
    // 스토리 모드 버튼 누를 시 상위 버튼들 화면 표출 중단

    public static bool storyModeEvent = false;

    public string storyModeButtonName;
    GameObject storyModeButton;
    public string quizModeButtonName;
    GameObject quizModeButton;
    public string backButtonName;
    GameObject backButton;

    StoryModeScripts storyModeScripts;
    public string storyModeName;

    void Start()
    {
        storyModeButton = GameObject.Find(storyModeButtonName);
        quizModeButton = GameObject.Find(quizModeButtonName);
        backButton = GameObject.Find(backButtonName);

        GameObject storyMode = GameObject.Find(storyModeName);
        storyModeScripts = storyMode.GetComponent<StoryModeScripts>();
    }

    void OnMouseDown()
    {
        storyModeButton.SetActive(false);
        quizModeButton.SetActive(false);
        backButton.SetActive(false);

        storyModeEvent = true;
    }
}
