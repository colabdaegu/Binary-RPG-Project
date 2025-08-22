using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScripts02 : MonoBehaviour
{
    // 텍스트02의 스크립트(프리팹박스02)

    private Text textComponent;
    private RectTransform rectTransform;

    void Start()
    {
        textComponent = GetComponent<Text>();
        rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        Vector3 targetPosition = Camera.main.WorldToScreenPoint(CloneScripts02.currentPosition02);
        rectTransform.position = targetPosition;

        textComponent.text = MainBossScripts.boxNum2.ToString();
    }
}