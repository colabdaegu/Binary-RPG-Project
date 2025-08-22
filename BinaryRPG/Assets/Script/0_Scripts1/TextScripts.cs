using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScripts : MonoBehaviour
{
    // 몬스터 텍스트 위치 배치
    public GameObject targetObject;
    public float offsetX = 0f; // X 좌표 오프셋
    public float offsetY = 0f; // Y 좌표 오프셋

    private Text textComponent;
    private RectTransform rectTransform;


    void Start()
    {
        textComponent = GetComponent<Text>();
        rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        // 타겟 오브젝트의 위치를 스크린 좌표로 변환하여 텍스트 위치 설정
        Vector3 inGamePos = targetObject.transform.position + new Vector3(offsetX, offsetY, 0f);
        Vector3 screenPos = Camera.main.WorldToScreenPoint(inGamePos);
        rectTransform.position = screenPos;   
    }
}