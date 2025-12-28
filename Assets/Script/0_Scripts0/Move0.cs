using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move0 : MonoBehaviour
{
    // 주인공 캐릭터 낙하하면서 이동

    private bool OneTime = true; 
    
    Rigidbody2D rbody;
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 한 번만
        if (OneTime)
        {
            rbody.velocity = new Vector2(5, 0);
            OneTime = false;
        }
        //Debug.Log(transform.position);
    }
}
