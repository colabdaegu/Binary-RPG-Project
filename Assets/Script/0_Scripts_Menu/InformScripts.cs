using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformScripts : MonoBehaviour
{
    public GameObject Inform;


    public void CloseInform()
    {
        if (Inform != null)
        {
            if (ClickQuizMapChange.QuizMode != 1)
            {
                this.gameObject.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }
}
