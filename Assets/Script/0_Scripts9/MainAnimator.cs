using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainAnimator : MonoBehaviour
{
    // 주인공 캐릭터 제어(애니메이션)
    
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.enabled = false;

        Invoke("AnimationOn", 2.8f);
    }


    void AnimationOn()
    {
        animator.enabled = true;
    }
}