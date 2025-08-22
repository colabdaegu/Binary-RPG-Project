using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGround : MonoBehaviour
{
    // ¶¥ ¿òÁ÷ÀÓ

    private bool MoveStart = false;
    public AudioClip bgmGameClear;

    Rigidbody2D rbody;
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();

        Invoke("GroundMove", 7f);
    }

    void FixedUpdate()
    {
        if (MoveStart)
        {
            rbody.velocity = new Vector2(-1, 0);
        }
    }


    void GroundMove()
    {
        MoveStart = true;

        AudioSource audioSourceGameClear = gameObject.AddComponent<AudioSource>();
        audioSourceGameClear.clip = bgmGameClear;
        audioSourceGameClear.Play();
    }
}
