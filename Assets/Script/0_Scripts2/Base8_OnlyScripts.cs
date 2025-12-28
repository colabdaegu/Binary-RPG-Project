using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base8_OnlyScripts : MonoBehaviour
{
    // 보스가 공격을 시작하면 지하공간 생성
    
    public string hideGroundObjectName;
    GameObject hideGroundObject;
    public string showGroundObjectName;
    GameObject showGroundObject;

    void Start()
    {
        hideGroundObject = GameObject.Find(hideGroundObjectName);
        showGroundObject = GameObject.Find(showGroundObjectName);
        showGroundObject.SetActive(false);
    }

    void Update()
    {
        if (PVPStarting.doThrow)
        {
            Invoke("TouchGround", 2f);
        }
    }


    void TouchGround()
    {
        hideGroundObject.SetActive(false);
        showGroundObject.SetActive(true);

        PVPStarting.doThrow = false;
    }
}
