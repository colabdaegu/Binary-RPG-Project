using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideAfterShow : MonoBehaviour
{
    // √÷√  Ω««‡ Ω√ º˚±Ë, ¥Í¿∏∏È µÓ¿Â
    public string showObjectName;
    public string targetObjectName;

    GameObject showObject;

    void Start()
    {
        showObject = GameObject.Find(showObjectName);
        showObject.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            showObject.SetActive(true);
        }
    }


}