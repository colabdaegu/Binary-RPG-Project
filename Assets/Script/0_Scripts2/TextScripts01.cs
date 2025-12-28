using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScripts01 : MonoBehaviour
{
    // 텍스트01의 스크립트(프리팹박스01)
    
    private Text textComponent;
    private RectTransform rectTransform;

    void Start()
    {
        textComponent = GetComponent<Text>();
        rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        Vector3 targetPosition = Camera.main.WorldToScreenPoint(CloneScripts01.currentPosition01);
        rectTransform.position = targetPosition;

        textComponent.text = MainBossScripts.boxNum1.ToString();
    }
}