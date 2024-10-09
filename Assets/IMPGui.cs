using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMPGui : MonoBehaviour
{
    public Animator animator;

    public void UIAnimation()
    {
        animator.SetTrigger("StartAnim");
    }
}
