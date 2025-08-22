using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContinueY : MonoBehaviour
{
    // 주인공의 X좌표 시점을 따라 화면이 이동한다

    Vector3 base_pos;

    void Start()
    {
        base_pos = Camera.main.gameObject.transform.position;
    }

    void LateUpdate()
    {
        Vector3 pos = this.transform.position;
        pos.z = -10;
        pos.y = base_pos.y;
        Camera.main.gameObject.transform.position = pos;
    }
}
