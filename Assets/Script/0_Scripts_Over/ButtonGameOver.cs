using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonGameOver : MonoBehaviour
{
    // 씬 전환 시 버튼 최초 숨김, 몇 초 후 생성 
    
    public string showObjectName;
    GameObject showObject;

    void Start()
    {
        showObject = GameObject.Find(showObjectName);
        showObject.SetActive(false);

        Invoke("showButton", 1);
    }


    void showButton()
    {
        showObject.SetActive(true);
    }
}
