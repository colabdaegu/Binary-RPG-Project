using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScripts04 : MonoBehaviour
{
    // 텍스트04의 스크립트(프리팹박스04)

    private Text textComponent;
    private RectTransform rectTransform;

    void Start()
    {
        textComponent = GetComponent<Text>();
        rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        Vector3 targetPosition = Camera.main.WorldToScreenPoint(CloneScripts04.currentPosition04);
        rectTransform.position = targetPosition;

        textComponent.text = MainBossScripts.boxNum4.ToString();
    }
}