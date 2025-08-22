using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScriptsForClear : MonoBehaviour
{
    // 씬 시작 부분(포탈, 주인공 등장 제어)

    public string portalObjectName; // Portal
    GameObject portalObject;
    public string mainObjectName;   // Main0
    GameObject mainObject;

    public string text1ObjectName;  // Text1
    GameObject text1Object;

    public string sceneName;

    void Start()
    {
        portalObject = GameObject.Find(portalObjectName);
        portalObject.SetActive(false);
        mainObject = GameObject.Find(mainObjectName);
        mainObject.SetActive(false);

        text1Object = GameObject.Find(text1ObjectName);
        text1Object.SetActive(false);

        Invoke("PortalObject", 2f);
        Invoke("MainObject", 4f);

        Invoke("PortalDestroy", 7f);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(sceneName);
        }
    }


    void PortalObject()
    {
        portalObject.SetActive(true);
    }

    void MainObject()
    {
        mainObject.SetActive(true);
    }

    void PortalDestroy()
    {
        portalObject.SetActive(false);

        text1Object.SetActive(true);
    }
}
