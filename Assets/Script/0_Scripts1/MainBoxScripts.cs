using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainBoxScripts : MonoBehaviour
{
    // 주인공 머리 위에 텍스트 틀[상자] 오브젝트 생성
    public GameObject targetObject;
    public float offsetX = 0f; // X 좌표 오프셋
    public float offsetY = 1f; // Y 좌표 오프셋 (타겟 오브젝트의 머리 위로 이동)

    private RectTransform rectTransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }


    void Update()
    {
        Vector3 inGamePos = targetObject.transform.position + new Vector3(offsetX, offsetY, 0f);
        Vector3 targetPosition = Camera.main.WorldToScreenPoint(inGamePos);
        rectTransform.position = targetPosition;
    }
}