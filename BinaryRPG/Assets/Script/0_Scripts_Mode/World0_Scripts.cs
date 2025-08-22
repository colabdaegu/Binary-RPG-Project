using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World0_Scripts : MonoBehaviour
{
    public string text1ObjectName;
    GameObject text1Object;
    public string text2ObjectName;
    GameObject text2Object;

    void Start()
    {
        text1Object = GameObject.Find(text1ObjectName);
        text1Object.SetActive(false);
        text2Object = GameObject.Find(text2ObjectName);
        text2Object.SetActive(false);

        Invoke("TextShow1", 0.5f);
        Invoke("TextShow2", 1.5f);
    }


    void TextShow1()
    {
        text1Object.SetActive(true);
    }
    void TextShow2()
    {
        text2Object.SetActive(true);
    }
}
