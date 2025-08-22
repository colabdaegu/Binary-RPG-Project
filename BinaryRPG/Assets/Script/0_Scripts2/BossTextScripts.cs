using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossTextScripts : MonoBehaviour
{
    public GameObject targetObject; // Boss
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
        // 정답을 아직 맞추지 않은 상태
        if (PVPStarting.isRight == false)
        {
            // 보스 오브젝트 위에 텍스트 오브젝트 표시
            Vector3 inGamePos = targetObject.transform.position + new Vector3(offsetX, offsetY, 0f);
            Vector3 targetPosition = Camera.main.WorldToScreenPoint(inGamePos);
            rectTransform.position = targetPosition;

            // 보스 텍스트 업데이트(.changeNum)
            textComponent.text = MainBossScripts.changeNum.ToString();
        }
        // 정답 맞췄을 시, 화면 밖으로 내보냄
        else
        {
            Vector3 textt = new Vector3(-500f, 1000f, 0f);
            transform.position = textt;
        }
    }
}