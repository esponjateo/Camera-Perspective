using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpGUI : MonoBehaviour
{
    public Animator Animator;

    public void UIanimation()
    {
        Animator.SetTrigger("Start Anim");
    }

}
