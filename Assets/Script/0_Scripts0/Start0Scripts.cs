using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start0Scripts : MonoBehaviour
{

    public string portalObjectName; // Portal
    GameObject portalObject;
    public string mainObjectName;   // Main0
    GameObject mainObject;

    void Start()
    {
        portalObject = GameObject.Find(portalObjectName);
        portalObject.SetActive(false);
        mainObject = GameObject.Find(mainObjectName);
        mainObject.SetActive(false);

        Invoke("PortalObject", 1.5f);
        Invoke("MainObject", 3f);
    }


    void PortalObject()
    {
        portalObject.SetActive(true);
    }

    void MainObject()
    {
        mainObject.SetActive(true);
    }
}
