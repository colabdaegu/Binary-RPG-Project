using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScripts05 : MonoBehaviour
{
    // 텍스트05의 스크립트(프리팹박스05)

    private Text textComponent;
    private RectTransform rectTransform;

    void Start()
    {
        textComponent = GetComponent<Text>();
        rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        Vector3 targetPosition = Camera.main.WorldToScreenPoint(CloneScripts05.currentPosition05);
        rectTransform.position = targetPosition;

        textComponent.text = MainBossScripts.boxNum5.ToString();
    }
}