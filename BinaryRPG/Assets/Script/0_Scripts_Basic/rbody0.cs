using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rbody0 : MonoBehaviour
{
    Rigidbody2D rbody;
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rbody.velocity = Vector2.zero;  // ¹Ì²ô·¯ÁüX
    }
}
