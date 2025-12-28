using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange0 : MonoBehaviour
{
    // ¾À ÀüÈ¯
    public string sceneName;
    public string mainObjectName;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == mainObjectName)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
