using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSave : MonoBehaviour
{
    // 트리거에 닿을 시 닿았을 때의 X좌표를 static 저장
    
    public string mainObjectName;
    GameObject mainObject;

    public static float triggerX;

    void Start()
    {
        mainObject = GameObject.Find(mainObjectName);
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == mainObjectName)
        {
            triggerX = mainObject.transform.position.x;
        }
    }
}
