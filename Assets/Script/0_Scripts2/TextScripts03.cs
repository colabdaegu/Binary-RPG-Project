using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScripts03 : MonoBehaviour
{
    // 텍스트03의 스크립트(프리팹박스03)

    private Text textComponent;
    private RectTransform rectTransform;

    void Start()
    {
        textComponent = GetComponent<Text>();
        rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        Vector3 targetPosition = Camera.main.WorldToScreenPoint(CloneScripts03.currentPosition03);
        rectTransform.position = targetPosition;

        textComponent.text = MainBossScripts.boxNum3.ToString();
    }
}