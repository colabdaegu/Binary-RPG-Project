using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPass : MonoBehaviour
{
    // 다음 장면으로 화면 전환
    Vector3 base_pos;

    void Start()
    {
        base_pos = Camera.main.gameObject.transform.position;
    }

    void LateUpdate()
    {
        Vector3 pos = this.transform.position;
        pos.z = -10;
        Camera.main.gameObject.transform.position = pos;
    }
}