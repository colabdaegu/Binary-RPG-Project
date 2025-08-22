using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitMapChange : MonoBehaviour
{
    // Æ÷Å» °¡µ¿
    public string sceneName;
    public string targetObjectName;

    public static bool portalBGM = false;     // BGM È°»óÈ­ ¿©ºÎ

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            portalBGM = true;

            // ¾À ³Ñ±è
            SceneManager.LoadScene(sceneName);
        }
    }
}
