using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyText : MonoBehaviour
{
    void Start()
    {
        // 몬스터의 텍스트를 삭제
        Destroy(this.gameObject);
    }
}
