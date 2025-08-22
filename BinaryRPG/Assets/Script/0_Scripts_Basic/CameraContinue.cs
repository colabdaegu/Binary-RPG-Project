using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContinue : MonoBehaviour
{
    // 주인공의 시점을 따라 화면이 이동한다

    void LateUpdate()
    {
        Vector3 pos = this.transform.position;
        pos.z = -10;
        Camera.main.gameObject.transform.position = pos;
    }
}
