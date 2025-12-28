using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLittleUnderY : MonoBehaviour
{
    // 주인공의 시점에서 Y좌표를 조금 아래로 해서 화면이 이동한다

    void LateUpdate()
    {
        Vector3 pos = this.transform.position;
        pos.y = this.transform.position.y + 2.5f;
        pos.z = -10;
        Camera.main.gameObject.transform.position = pos;
    }
}
