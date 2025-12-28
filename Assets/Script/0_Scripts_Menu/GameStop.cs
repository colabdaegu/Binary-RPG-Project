using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStop : MonoBehaviour
{
    void Start()
    {
        if (ClickQuizMapChange.QuizMode != 1)
        {
            Time.timeScale = 0;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
