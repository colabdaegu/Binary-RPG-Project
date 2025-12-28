using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Destroy : MonoBehaviour
{
    // 왼쪽 마우스 클릭 시 사라짐

    void Update()
    {
        if (ClickQuizMapChange.QuizMode != 1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Time.timeScale = 1;
                Destroy(this.gameObject);
            }
        }
    }
}
