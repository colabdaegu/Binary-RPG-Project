using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCamera : MonoBehaviour
{
    // 트리거 영역에 진입 시 카메라 전환 스크립트 활성화
    
    CameraPass cameraPass;
    public string cameraPassName;

    void Start()
    {
        GameObject CameraP = GameObject.Find(cameraPassName);
        cameraPass = CameraP.GetComponent<CameraPass>();
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        cameraPass.enabled = true;

        gameObject.GetComponent<StartBGM>().enabled = true;
    }
}
