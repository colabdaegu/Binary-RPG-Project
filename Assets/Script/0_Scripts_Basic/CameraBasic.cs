using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBasic : MonoBehaviour
{
    // 주인공의 시점을 따라 화면이 이동한다
    Vector3 base_pos;
    Vector3 pos;

    Vector3 nowPosition;
    Vector3 beforePosition;

    void Start()
    {
        pos = transform.position;
    }

    void LateUpdate()
    {
        nowPosition = transform.position;

        Invoke("BeforePosition", 0.1f);

        pos.x = transform.position.x;
        if (beforePosition == nowPosition)
        {
            pos.y = transform.position.y;
        }
        pos.z = -10;

        Camera.main.gameObject.transform.position = pos;
    }

    void BeforePosition()
    {
        beforePosition = nowPosition;
    }
}
