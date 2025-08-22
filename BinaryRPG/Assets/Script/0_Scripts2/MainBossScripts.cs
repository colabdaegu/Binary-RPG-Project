using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBossScripts : MonoBehaviour
{
    // 스크립트 비활성화 상태로 시작


    public int BASE;    // 진법 변환 베이스(2진수/8진수/16진수 택)
    private int NUM;    // 보스의 기본 숫자
    private string changeN;     // 보스 (2진수/8진수/16진수) 값
    private int decimalN;     // 보스 10진수 값
    public static string changeNum;     // 보스 (2진수/8진수/16진수) 값의 static 변수
    public static int decimalNum;     // 보스 10진수 값의 static 변수


    public static int bossLife = 3;     // 보스 HP


    public GameObject newPrefab1;   // box1(프리팹)
    public GameObject newPrefab2;   // box2(프리팹)
    public GameObject newPrefab3;   // box3(프리팹)
    public GameObject newPrefab4;   // box4(프리팹)
    public GameObject newPrefab5;   // box5(프리팹)

    private float throwX1 = 6;    // 던지는 힘
    private float throwX2 = 6;    // 던지는 힘
    private float throwX3 = 6;    // 던지는 힘
    private float throwX4 = 5;    // 던지는 힘
    private float throwX5 = 7;    // 던지는 힘

    private float throwY1 = 6;    // 던지는 힘
    private float throwY2 = 6;    // 던지는 힘
    private float throwY3 = 6;    // 던지는 힘
    private float throwY4 = 5;    // 던지는 힘
    private float throwY5 = 8;    // 던지는 힘


    // 주인공 캐릭터 감지
    public string mainObjectName;
    GameObject mainObject;


    private int Num1;   // 정답값
    private int Num2;   // 정답 제외 랜덤값
    private int Num3;   // 정답 제외 랜덤값
    private int Num4;   // 정답 제외 랜덤값
    private int Num5;   // 정답 제외 랜덤값

    // 정답값 포함 랜덤 재배치한 값
    public static int boxNum1;
    public static int boxNum2;
    public static int boxNum3;
    public static int boxNum4;
    public static int boxNum5;


    // 텍스트 스크립트 및 오브젝트
    TextScripts01 textScripts01;
    public string textObjectName01;
    TextScripts02 textScripts02;
    public string textObjectName02;
    TextScripts03 textScripts03;
    public string textObjectName03;
    TextScripts04 textScripts04;
    public string textObjectName04;
    TextScripts05 textScripts05;
    public string textObjectName05;


    // 텍스트툴[박스]의 스크립트 및 오브젝트
    CloneScripts01 cloneScripts01;
    public string cloneObjectName01;
    CloneScripts02 cloneScripts02;
    public string cloneObjectName02;
    CloneScripts03 cloneScripts03;
    public string cloneObjectName03;
    CloneScripts04 cloneScripts04;
    public string cloneObjectName04;
    CloneScripts05 cloneScripts05;
    public string cloneObjectName05;


    public static bool bossEventBGM = false;     // BGM 활상화 여부


    void Start()
    {
        // 주인공 캐릭터 확인 및 저장
        mainObject = GameObject.Find(mainObjectName);


        // 텍스트 스크립트 및 오브젝트 확인 및 저장
        GameObject textBoxObject1 = GameObject.Find(textObjectName01);
        textScripts01 = textBoxObject1.GetComponent<TextScripts01>();

        GameObject textBoxObject2 = GameObject.Find(textObjectName02);
        textScripts02 = textBoxObject2.GetComponent<TextScripts02>();

        GameObject textBoxObject3 = GameObject.Find(textObjectName03);
        textScripts03 = textBoxObject3.GetComponent<TextScripts03>();

        GameObject textBoxObject4 = GameObject.Find(textObjectName04);
        textScripts04 = textBoxObject4.GetComponent<TextScripts04>();

        GameObject textBoxObject5 = GameObject.Find(textObjectName05);
        textScripts05 = textBoxObject5.GetComponent<TextScripts05>();


        // 텍스트툴[박스]의 스크립트 및 오브젝트 확인 및 저장
        GameObject cloneObject1 = GameObject.Find(cloneObjectName01);
        cloneScripts01 = cloneObject1.GetComponent<CloneScripts01>();

        GameObject cloneObject2 = GameObject.Find(cloneObjectName02);
        cloneScripts02 = cloneObject2.GetComponent<CloneScripts02>();

        GameObject cloneObject3 = GameObject.Find(cloneObjectName03);
        cloneScripts03 = cloneObject3.GetComponent<CloneScripts03>();

        GameObject cloneObject4 = GameObject.Find(cloneObjectName04);
        cloneScripts04 = cloneObject4.GetComponent<CloneScripts04>();

        GameObject cloneObject5 = GameObject.Find(cloneObjectName05);
        cloneScripts05 = cloneObject5.GetComponent<CloneScripts05>();
    }

    void Update()
    {
        // 보스 기본 숫자 랜덤 선정
        NUM = UnityEngine.Random.Range(32, 255);
        Debug.Log(NUM);

        // 값을 (2진수/8진수/16진수)로 변환 및 저장
        changeN = Convert.ToString(NUM, BASE);
        changeNum = changeN;    // 다른 스크립트에서 사용할 값 static
        Debug.Log(changeN);

        // 다시, 값을 10진수로 변환 및 저장
        decimalN = Convert.ToInt32(changeN, BASE);
        decimalNum = decimalN;    // 다른 스크립트에서 사용할 값 static
        Debug.Log(decimalN);



        // 프리팹 배치할 위치(보스 오브젝트 기준 +)
        Vector3 newPos1 = this.transform.position + new Vector3(-1.3f, 4f, 0f);
        Vector3 newPos2 = this.transform.position + new Vector3(-0.6f, 1.9f, 0f);
        Vector3 newPos3 = this.transform.position + new Vector3(0.6f, 1.9f, 0f);
        Vector3 newPos4 = this.transform.position + new Vector3(1.3f, 4f, 0f);
        Vector3 newPos5 = this.transform.position + new Vector3(0f, 5.2f, 0f);


        /* 기본 프리팹 3개부터 시작 */
        bossEventBGM = true;
        // 프리팹(1)
        GameObject newGameObject1 = Instantiate(newPrefab1) as GameObject;
        newPos1.z = -5;  // 앞에 표시한다
        newGameObject1.transform.position = newPos1;
        Rigidbody2D rbody1 = newGameObject1.GetComponent<Rigidbody2D>();

        // 프리팹(2)
        GameObject newGameObject2 = Instantiate(newPrefab2) as GameObject;
        newPos2.z = -5;  // 앞에 표시한다
        newGameObject2.transform.position = newPos2;
        Rigidbody2D rbody2 = newGameObject2.GetComponent<Rigidbody2D>();

        // 프리팹(3)
        GameObject newGameObject3 = Instantiate(newPrefab3) as GameObject;
        newPos3.z = -5;  // 앞에 표시한다
        newGameObject3.transform.position = newPos3;
        Rigidbody2D rbody3 = newGameObject3.GetComponent<Rigidbody2D>();

        // 주인공과 보스의 위치에 따라 프리팹 던지는 방향 달라짐
        if (mainObject.transform.position.x < transform.position.x)
        {
            rbody1.AddForce(new Vector2(-throwX1, throwY1), ForceMode2D.Impulse);
            rbody2.AddForce(new Vector2(-throwX2, throwY2), ForceMode2D.Impulse);
            rbody3.AddForce(new Vector2(-throwX3, throwY3), ForceMode2D.Impulse);
        }
        else
        {
            rbody1.AddForce(new Vector2(throwX4, throwY4), ForceMode2D.Impulse);
            rbody2.AddForce(new Vector2(throwX2, throwY2), ForceMode2D.Impulse);
            rbody3.AddForce(new Vector2(throwX3, throwY3), ForceMode2D.Impulse);
        }


        // 보스의 HP가 -1이 됐을 때
        if (bossLife <= 2)
        {
            // 프리팹(4)
            GameObject newGameObject4 = Instantiate(newPrefab4) as GameObject;
            newPos4.z = -5;  // 앞에 표시한다
            newGameObject4.transform.position = newPos4;
            Rigidbody2D rbody4 = newGameObject4.GetComponent<Rigidbody2D>();

            // 주인공과 보스의 위치에 따라 프리팹 던지는 방향 달라짐
            if (mainObject.transform.position.x < transform.position.x)
            {
                rbody4.AddForce(new Vector2(-throwX4, throwY4), ForceMode2D.Impulse);
            }
            else
            {
                rbody4.AddForce(new Vector2(throwX1, throwY1), ForceMode2D.Impulse);
            }
        }


        // 보스의 HP가 -2가 됐을 때
        if (bossLife <= 1)
        {
            // 프리팹(5)
            GameObject newGameObject5 = Instantiate(newPrefab5) as GameObject;
            newPos5.z = -5;  // 앞에 표시한다
            newGameObject5.transform.position = newPos5;
            Rigidbody2D rbody5 = newGameObject5.GetComponent<Rigidbody2D>();

            // 주인공과 보스의 위치에 따라 프리팹 던지는 방향 달라짐
            if (mainObject.transform.position.x < transform.position.x)
            {
                rbody5.AddForce(new Vector2(-throwX5, throwY5), ForceMode2D.Impulse);
            }
            else
            {
                rbody5.AddForce(new Vector2(throwX5, throwY5), ForceMode2D.Impulse);
            }
        }


        // 보스 HP가 3일 때(기본)
        if (bossLife == 3)
        {
            // 3개 값
            Num1 = decimalN;
            Num2 = UnityEngine.Random.Range(50, decimalN - 30);
            Num3 = UnityEngine.Random.Range(decimalN + 1, decimalN + 50);

            List<int> variables = new List<int> { Num1, Num2, Num3 };

            //UnityEngine.Random.InitState((int)DateTime.Now.Ticks);  // 시드를 현재 시간으로 설정

            // Fisher-Yates 셔플 알고리즘을 사용하여 랜덤 재배치
            int n = variables.Count;
            while (n > 1)
            {
                n--;
                int k = UnityEngine.Random.Range(0, n + 1);
                int temp = variables[k];
                variables[k] = variables[n];
                variables[n] = temp;
            }

            // 배열에서 재배치한 값을 각각의 boxNum에 저장 (static)
            boxNum1 = variables[0];
            boxNum2 = variables[1];
            boxNum3 = variables[2];
        }
        // 보스 HP가 2일 때
        else if (bossLife == 2)
        {
            // 4개 값
            Num1 = decimalN;
            Num2 = UnityEngine.Random.Range(50, decimalN - 30);
            Num3 = UnityEngine.Random.Range(decimalN + 1, decimalN + 50);
            Num4 = UnityEngine.Random.Range(boxNum2 + 1, decimalN);

            List<int> variables = new List<int> { Num1, Num2, Num3, Num4 };

            //UnityEngine.Random.InitState((int)DateTime.Now.Ticks);  // 시드를 현재 시간으로 설정

            // Fisher-Yates 셔플 알고리즘을 사용하여 랜덤 재배치
            int n = variables.Count;
            while (n > 1)
            {
                n--;
                int k = UnityEngine.Random.Range(0, n + 1);
                int temp = variables[k];
                variables[k] = variables[n];
                variables[n] = temp;
            }

            // 배열에서 재배치한 값을 각각의 boxNum에 저장 (static)
            boxNum1 = variables[0];
            boxNum2 = variables[1];
            boxNum3 = variables[2];
            boxNum4 = variables[3];
        }
        // 보스 HP가 1일 때
        else if (bossLife == 1)
        {
            // 5개 값
            Num1 = decimalN;
            Num2 = UnityEngine.Random.Range(50, decimalN - 30);
            Num3 = UnityEngine.Random.Range(decimalN + 1, decimalN + 50);
            Num4 = UnityEngine.Random.Range(boxNum2 + 1, decimalN);
            Num5 = UnityEngine.Random.Range(boxNum3 + 1, 500);

            List<int> variables = new List<int> { Num1, Num2, Num3, Num4, Num5 };

            //UnityEngine.Random.InitState((int)DateTime.Now.Ticks);  // 시드를 현재 시간으로 설정

            // Fisher-Yates 셔플 알고리즘을 사용하여 랜덤 재배치
            int n = variables.Count;
            while (n > 1)
            {
                n--;
                int k = UnityEngine.Random.Range(0, n + 1);
                int temp = variables[k];
                variables[k] = variables[n];
                variables[n] = temp;
            }

            // 배열에서 재배치한 값을 각각의 boxNum에 저장 (static)
            boxNum1 = variables[0];
            boxNum2 = variables[1];
            boxNum3 = variables[2];
            boxNum4 = variables[3];
            boxNum5 = variables[4];
        }


        // 텍스트 스크립트 활성화
        textScripts01.enabled = true;
        textScripts02.enabled = true;
        textScripts03.enabled = true;
        textScripts04.enabled = true;
        textScripts05.enabled = true;


        // 텍스트툴[박스]의 스크립트 활성화
        cloneScripts01.enabled = true;
        cloneScripts02.enabled = true;
        cloneScripts03.enabled = true;
        cloneScripts04.enabled = true;
        cloneScripts05.enabled = true;



        // 스크립트 종료
        this.enabled = false;
    }
}
