using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public static Animator animationController;

    private void Awake()
    {
        animationController = animationController.GetComponent<Animator>();
    }

    public static void CloseClaw()
    {
        animationController.SetBool("close", true);
    }

    public static void OpenClaw()
    {
        animationController.SetBool("close", false);
    }
}
