using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelScripts : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Button;
    public string sceneName;

    public void OpenPanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
            this.gameObject.SetActive(false);
            Time.timeScale = 0;
        }
    }

    public void ClosePanel()
    {
        if (Panel != null)
        {
            Button.SetActive(true);
            Panel.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void TitleReturn()
    {
        if (Panel != null)
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(sceneName);

            PVPStarting.life = 3;
            MainBossScripts.bossLife = 3;

            MainCharScripts.monsterPocket = true;

            BGMHit.gameStart = false;
            PVPStarting.doThrow = false;

            ClickQuizMapChange.QuizMode = 0;

            ClickStoryMode.storyModeEvent = false;
        }
    }
}
