using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PVPStarting : MonoBehaviour
{
    // 최초 스크립트 활성화


    public string targetObjectName; // 주인공(Main2)
    public static int life = 3; // 주인공 HP


    public string showObjectName1;  // 잔여 HP 화면에 표시(1)
    public string showObjectName2;  // 잔여 HP 화면에 표시(2)
    public string showObjectName3;  // 잔여 HP 화면에 표시(3)
    GameObject showObject1;
    GameObject showObject2;
    GameObject showObject3;


    // 보스 텍스트-완전삭제 스크립트
    DestroyText2 destroyText2;
    public string destroyTextName;

    // 보스 텍스트 스크립트
    BossTextScripts bossTextScripts;
    public string bossTextScriptsName;



    // [이전 스테이지로부터의] 포탈 오브젝트
    public string portalBaseName;
    GameObject portalBase;


    // 폭발 오브젝트(보스 사망 시)
    public string bombActionName;
    GameObject bombAction;



    // 아이템 생성 스크립트
    ItemPrefabAddScripts itemPrefabAddScripts;
    public string itemPrefabAddScriptsName;


    // 포탈 스크립트
    HitMapChange2 hitMapChange2;
    public string hitMapChange2Name;


    public string sceneName;    // GameOver 씬


    // 정답을 맞춘 상태인지
    public static bool isRight = false;

    // 보스가 오브젝트를 던졌는지(Base8_OnlyScripts에서 사용)
    public static bool doThrow = false;

    // 한 번만 실행
    bool OneTimeGame = true;
    bool OneTime = true;
    bool OneTimes = true;


    void Start()
    {
        gameObject.GetComponent<MainBossScripts>().enabled = true;  // MainBossScripts 스크립트 활성화(오류 해결 위함)

        // 잔여 HP 표시 오브젝트 확인 및 저장
        showObject1 = GameObject.Find(showObjectName1);
        showObject2 = GameObject.Find(showObjectName2);
        showObject3 = GameObject.Find(showObjectName3);


        // 보스 텍스트-완전삭제 스크립트 확인 및 저장
        GameObject destroyT = GameObject.Find(destroyTextName);
        destroyText2 = destroyT.GetComponent<DestroyText2>();

        // 보스 텍스트 스크립트 확인 및 저장
        GameObject bossT = GameObject.Find(bossTextScriptsName);
        bossTextScripts = bossT.GetComponent<BossTextScripts>();


        // [이전 스테이지로부터의] 포탈 오브젝트 확인 및 저장
        portalBase = GameObject.Find(portalBaseName);
        Destroy(portalBase, 3); // 3초 후 오브젝트 삭제


        // 폭발 오브젝트(보스 사망 시) 확인 및 저장
        bombAction = GameObject.Find(bombActionName);
        bombAction.SetActive(false);    // 실행 시 즉시 숨김



        // 아이템 생성 스크립트 확인 및 저장
        GameObject ItemAdd = GameObject.Find(itemPrefabAddScriptsName);
        itemPrefabAddScripts = ItemAdd.GetComponent<ItemPrefabAddScripts>();


        // 포탈 스크립트 확인 및 저장
        GameObject hitMap = GameObject.Find(hitMapChange2Name);
        hitMapChange2 = hitMap.GetComponent<HitMapChange2>();
    }

    void Update()
    {
        // 주인공이 게임 시작 시점 도달 시
        if (BGMHit.gameStart && OneTimeGame)
        {
            OneTimeGame = false;

            //'퀴즈 스크립트' 1초 후 실행(게임 최초 시작)
            Invoke("QuizScripts", 1f);

            doThrow = true; // 보스가 오브젝트를 던졌는지(Base8_OnlyScripts에서 사용)
        }


        // 주인공 HP에 따라 잔여 HP 오브젝트 표시
        if (life == 3)
        {
            showObject1.SetActive(true);
            showObject2.SetActive(true);
            showObject3.SetActive(true);
        }
        else if (life == 2)
        {
            showObject1.SetActive(true);
            showObject2.SetActive(true);
            showObject3.SetActive(false);
        }
        else if (life == 1)
        {
            showObject1.SetActive(true);
            showObject2.SetActive(false);
            showObject3.SetActive(false);
        }
        else if (life == 0)
        {
            showObject1.SetActive(false);
            showObject2.SetActive(false);
            showObject3.SetActive(false);

            // HP가 0일 시 GameOver 씬으로 전환
            SceneManager.LoadScene(sceneName);
        }

        // 주인공 HP 3 초과 불가
        if (life > 3)
        {
            life = 3;
        }


        // 보스 HP가 2가 됐을 시
        if (MainBossScripts.bossLife == 2 && OneTime)
        {
            // 8초 후에 '퀴즈 스크립트' 실행
            Invoke("QuizScripts", 8f);
            OneTime = false;
        }
        // 보스 HP가 1이 됐을 시
        if (MainBossScripts.bossLife == 1 && OneTimes)
        {
            // 10초 후에 '퀴즈 스크립트' 실행
            Invoke("QuizScripts", 10f);
            OneTimes = false;
        }
        // 보스 HP가 0이 됐을 시
        if (MainBossScripts.bossLife == 0)
        {
            //Destroy(this.gameObject);
            destroyText2.enabled = true;    // 보스 텍스트-완전삭제 스크립트 활성화

            // 폭발 오브젝트(보스 사망 시) 보스 위치로 이동 및 보이게
            bombAction.transform.position = transform.position;
            bombAction.SetActive(true);

            Destroy(bombAction, 2f);    // 2초 후 삭제


            hitMapChange2.enabled = true;   // 포탈 스크립트 활성화
        }
    }


    /* 퀴즈 스크립트 */
    void QuizScripts()
    {
        gameObject.GetComponent<MainBossScripts>().enabled = true;    // MainBossScripts 스크립트 활성화
        bossTextScripts.enabled = true;     // 보스 텍스트 스크립트 활성화
        itemPrefabAddScripts.enabled = true;    // 아이템 생성 스크립트 활성화

        isRight = false;    // 정답을 아직 맞추지 않은 상태로 전환
    }
}
