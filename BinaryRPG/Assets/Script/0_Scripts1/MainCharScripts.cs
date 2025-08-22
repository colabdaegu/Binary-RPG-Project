using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainCharScripts : MonoBehaviour
{
    public int BASE;    // 진법 변환 베이스(2진수/8진수/16진수 택)
    private int NUM;    // 몬스터의 기본 숫자
    private string changeNum;     // 몬스터 (2진수/8진수/16진수) 값
    private int decimalNum;     // 몬스터 10진수 값

    bool updateGo = false;  // Update 반복 및 활성화 가능 여부

    bool okay = true;   // 키 입력 가능 여부
    private int sum = 0;  // 입력한 값
    public static string showSum = "10진수 값은? : \n";     // 입력값 출력용 변수

    public GameObject newPrefab;    // 생명력 -1 카운트 (프리팹)

    public GameObject deathCountPrefab;     // 몬스터 죽인 수 카운트 (프리팹)

    public GameObject deathImagePrefab;  // 몬스터 시체 쌓이는 연출[포탈 영역] (프리팹) 


    // 몬스터 사망 시 시체 출력 (프리팹)
    public GameObject showObjectPrefab;
    GameObject showObject;

    // 몬스터 사망 시 아이템 출력 (프리팹)
    public GameObject itemObjectPrefab;
    GameObject itemObject;
    private int itemRandom;

    // 몬스터를 공격[마법진] (프리팹) 
    public GameObject attackObjectPrefab;
    GameObject attackObject;

    // 주인공을 공격[fire] (프리팹)
    public GameObject firePrefab;

    // 주인공 캐릭터 감지
    public string mainObjectName;
    GameObject mainObject;


    // 몬스터의 숫자 텍스트 출력 및 삭제
    TextScripts textScripts;
    DestroyText destroyText;
    public string textObjectName;
    private Text textComponent;

    // 주인공의 텍스트박스 출력
    MainBoxScripts mainBoxScripts;
    public string mainBoxObjectName;

    // 주인공의 입력 숫자 출력
    MainTextScripts mainTextScripts;
    public string mainTextObjectName;


    // 주인공 텍스트[박스] 위치 변경
    public Transform otherBoxTransform;

    // 주인공 [텍스트]값 위치 변경
    public Transform otherTextTransform;


    // 주인공 움직임 제한(버그 방지용) 오브젝트
    public Transform bugFixTransform;

    // 생명력 카운트 오브젝트 위치
    public Transform mainBox;

    // 몬스터 처치 카운트 오브젝트 위치
    public Transform redBox;

    // 몬스터 처치 카운트 연출 오브젝트 위치
    public Transform pocketBox;

    // 몬스터 시체 쌓이는 연출 표시 활성화 여부
    public static bool monsterPocket = true;


    public static bool magicAttackBGM = false;     // BGM 활상화 여부
    public static bool deathMonsterBGM = false;     // BGM 활상화 여부
    public static bool fireAttackBGM = false;     // BGM 활상화 여부


    void Start()
    {
        // 몬스터 기본 숫자 랜덤 선정
        NUM = UnityEngine.Random.Range(10, 31);

        // 값을 (2진수/8진수/16진수)로 변환 및 저장
        changeNum = Convert.ToString(NUM, BASE);

        // 다시, 값을 10진수로 변환 및 저장
        decimalNum = Convert.ToInt32(changeNum, BASE);


        // 몬스터 시체 출력 (프리팹)
        showObject = Instantiate(showObjectPrefab, transform.position, Quaternion.identity);
        showObject.SetActive(false);

        // 아이템 랜덤 생성 (프리팹)
        itemObject = Instantiate(itemObjectPrefab, transform.position, Quaternion.identity);
        itemObject.SetActive(false);
        itemRandom = UnityEngine.Random.Range(1, 8);

        // 몬스터를 공격 (프리팹)
        attackObject = Instantiate(attackObjectPrefab, transform.position, Quaternion.identity);
        attackObject.SetActive(false);

        // 주인공 캐릭터 확인 및 저장
        mainObject = GameObject.Find(mainObjectName);


        // 몬스터의 숫자 텍스트 출력 및 삭제
        GameObject textBoxObject = GameObject.Find(textObjectName);
        textScripts = textBoxObject.GetComponent<TextScripts>();
        textComponent = GameObject.Find(textObjectName).GetComponent<Text>();
        textComponent.text = changeNum.ToString();
        destroyText = textBoxObject.GetComponent<DestroyText>();

        // 주인공 텍스트[박스] 위치 변경
        GameObject mainBoxObject = GameObject.Find(mainBoxObjectName);
        mainBoxScripts = mainBoxObject.GetComponent<MainBoxScripts>();

        // 주인공 [텍스트]값 위치 변경
        GameObject mainTextObject = GameObject.Find(mainTextObjectName);
        mainTextScripts = mainTextObject.GetComponent<MainTextScripts>();
    }

    // 주인공과 몬스터가 닿을 시 updateGo를 true하여 void Update() 활성화
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == mainObjectName)
        {
            updateGo = true;
        }
    }

    void Update()
    {
        // Update 반복 활성화
        if (updateGo)
        {
            // 입력 가능 여부
            if (okay)
            {
                // 값 입력
                if (Input.GetKeyUp(KeyCode.Keypad1) || Input.GetKeyUp(KeyCode.Alpha1))
                {
                    sum = (sum * 10) + 1;
                    showSum = "10진수 값은? : \n" + sum.ToString();
                }
                if (Input.GetKeyUp(KeyCode.Keypad2) || Input.GetKeyUp(KeyCode.Alpha2))
                {
                    sum = (sum * 10) + 2;
                    showSum = "10진수 값은? : \n" + sum.ToString();
                }
                if (Input.GetKeyUp(KeyCode.Keypad3) || Input.GetKeyUp(KeyCode.Alpha3))
                {
                    sum = (sum * 10) + 3;
                    showSum = "10진수 값은? : \n" + sum.ToString();
                }
                if (Input.GetKeyUp(KeyCode.Keypad4) || Input.GetKeyUp(KeyCode.Alpha4))
                {
                    sum = (sum * 10) + 4;
                    showSum = "10진수 값은? : \n" + sum.ToString();
                }
                if (Input.GetKeyUp(KeyCode.Keypad5) || Input.GetKeyUp(KeyCode.Alpha5))
                {
                    sum = (sum * 10) + 5;
                    showSum = "10진수 값은? : \n" + sum.ToString();
                }
                if (Input.GetKeyUp(KeyCode.Keypad6) || Input.GetKeyUp(KeyCode.Alpha6))
                {
                    sum = (sum * 10) + 6;
                    showSum = "10진수 값은? : \n" + sum.ToString();
                }
                if (Input.GetKeyUp(KeyCode.Keypad7) || Input.GetKeyUp(KeyCode.Alpha7))
                {
                    sum = (sum * 10) + 7;
                    showSum = "10진수 값은? : \n" + sum.ToString();
                }
                if (Input.GetKeyUp(KeyCode.Keypad8) || Input.GetKeyUp(KeyCode.Alpha8))
                {
                    sum = (sum * 10) + 8;
                    showSum = "10진수 값은? : \n" + sum.ToString();
                }
                if (Input.GetKeyUp(KeyCode.Keypad9) || Input.GetKeyUp(KeyCode.Alpha9))
                {
                    sum = (sum * 10) + 9;
                    showSum = "10진수 값은? : \n" + sum.ToString();
                }
                if (Input.GetKeyUp(KeyCode.Keypad0) || Input.GetKeyUp(KeyCode.Alpha0))
                {
                    sum = (sum * 10) + 0;
                    showSum = "10진수 값은? : \n" + sum.ToString();
                }
            }
            // 값이 0일 시 남은 수 미출력
            if (sum == 0)
            {
                showSum = "10진수 값은? : \n";
            }

            // 한 자리씩 값 지우기
            if (Input.GetKeyUp("backspace"))
            {
                sum = sum / 10;
                showSum = "10진수 값은? : \n" + sum.ToString();
            }

            // 값 최종입력
            if (Input.GetKeyUp("return"))
            {
                okay = false;   // 값 입력 중단

                // 정답이면
                if (sum == decimalNum)
                {
                    Debug.Log("정답");

                    // 입력값 초기화
                    sum = 0;
                    showSum = "10진수 값은? : \n";


                    // 몬스터 죽인 수 카운트 (프리팹)
                    Vector3 monsterDeathCount = redBox.transform.position + new Vector3(0, 15, 0);
                    GameObject newObjectDeathCount = Instantiate(deathCountPrefab, monsterDeathCount, Quaternion.identity);

                    if (monsterPocket)  // 포탈 생성 이후 처치한 몬스터에 대해서는 false하여 화면에 표시X
                    {
                        // 몬스터 시체 쌓이는 연출[포탈 영역] (프리팹)
                        Vector3 monsterPocketCount = pocketBox.transform.position + new Vector3(0, 5, 0);
                        GameObject newObjectDeathImage = Instantiate(deathImagePrefab, monsterPocketCount, Quaternion.identity);
                    }

                    // 몬스터 사망 시 출력되는 오브젝트 표시위치 지정(시체,아이템,몬스터를공격)
                    showObject.transform.position = transform.position + new Vector3(0, -0.7f, 0);
                    itemObject.transform.position = transform.position;
                    attackObject.transform.position = transform.position;
                    // 아이템 또는 시체 표시(7이면 아이템, 그밖에는 시체)
                    if (itemRandom == 7)
                    {
                        itemObject.SetActive(true);
                    }
                    else
                    {
                        showObject.SetActive(true);
                        Destroy(showObject, 2);
                    }
                    // 몬스터를 공격[마법진]
                    attackObject.SetActive(true);
                    Destroy(attackObject, 1);

                    magicAttackBGM = true;


                    // 몬스터의 텍스트 출력을 중단하고, 완전 삭제 스크립트 활성화
                    textScripts.enabled = false;
                    destroyText.enabled = true;


                    // 주인공의 박스가 화면에 표시 중지
                    mainBoxScripts.enabled = false;
                    Vector3 boxx = new Vector3(-500f, 1000f, 0f);
                    otherBoxTransform.position = boxx;

                    // 주인공의 텍스트가 화면에 표시 중지
                    mainTextScripts.enabled = false;
                    Vector3 textt = new Vector3(-500f, 1000f, 0f);
                    otherTextTransform.position = textt;


                    // 주인공 움직임 제한(버그 방지용) 해제
                    Vector3 bugFix = new Vector3(200f, 500f, 0f);
                    bugFixTransform.position = bugFix;



                    // 이 스크립트를 최종 중단
                    this.enabled = false;
                    // 이 몬스터를 최종 삭제
                    Destroy(this.gameObject);

                    deathMonsterBGM = true;
                }
                // 오답이면
                else
                {
                    Debug.Log("오답");

                    // 입력값 초기화
                    sum = 0;
                    showSum = "10진수 값은? : \n";

                    // 값 입력 계속해서 진행
                    okay = true;


                    // 주인공 방향으로 공격 연출 (프리팹)
                    GameObject fire = Instantiate(firePrefab, transform.position, Quaternion.identity);
                    Vector2 dir = (mainObject.transform.position - this.transform.position);
                    // 회전 각도 계산
                    float angle = Mathf.Atan2(-dir.y, -dir.x) * Mathf.Rad2Deg;
                    fire.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

                    fire.GetComponent<Rigidbody2D>().velocity = dir;
                    fireAttackBGM = true;


                    Vector3 hpMinusCount = mainBox.transform.position + new Vector3(2, 6, 0);
                    // 생명력 -1 카운트 (프리팹)
                    GameObject newObject = Instantiate(newPrefab, hpMinusCount, Quaternion.identity);
                }
            }
        } 
    }
}