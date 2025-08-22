using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDestroyMe : MonoBehaviour
{
    // 닿으면 나 자신이 사라짐
    public string targetObjectName;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            Destroy(this.gameObject);
        }
    }
}
