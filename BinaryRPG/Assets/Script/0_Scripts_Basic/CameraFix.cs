using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFix : MonoBehaviour
{
    // 카메라 비율 고정

    void Start()
    {
        Camera.main.aspect = 16f / 9f;
    }

}
