using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorOff : MonoBehaviour
{
    // 주인공 캐릭터 제어(애니메이션)

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();

        Invoke("AnimationOff", 6.1f);
    }


    void AnimationOff()
    {
        animator.enabled = false;
    }
}
