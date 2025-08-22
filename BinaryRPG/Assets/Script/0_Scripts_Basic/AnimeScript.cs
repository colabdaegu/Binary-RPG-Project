using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimeScript : MonoBehaviour
{
    // 키를 누르면 애니메이션을 전환한다
    public string leftAnime = "";
    public string rightAnime = "";

    string nowMode = "";

    void Start()
    {
        nowMode = rightAnime;
    }

    void Update()
    {
        if (Input.GetKey("left"))
        {
            nowMode = leftAnime;
        }
        if (Input.GetKey("right"))
        {
            nowMode = rightAnime;
        }
    }

    void FixedUpdate()
    {
        this.GetComponent<Animator>().Play(nowMode);
    }
}
