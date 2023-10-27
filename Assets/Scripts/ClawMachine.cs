using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateEnum;

public class ClawMachine : MonoBehaviour
{
    private StateMachine stateMachine;
    private State currentState;
    public static GameObject thisGo;
    public static float craneSpeed = 0.2f;

    [Header("Animator Stuff")]
    public GameObject animatorGo;
    public Animator clawAnimation;
    public static bool craneClose;
    void Awake()
    {
        stateMachine = new StateMachine();
        clawAnimation = animatorGo.GetComponent<Animator>();
        currentState = State.Open;
        thisGo = this.gameObject;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (currentState == State.Open)
        {
            currentState = State.Open;
            stateMachine.ChangeState(currentState);
            stateMachine.Update();

            if (Input.GetKey(KeyCode.Space))
            {
                Debug.Log("Space is pressed");
                clawAnimation.SetBool("close", true);   
            }

            if (Input.GetKey(KeyCode.LeftControl))
            {
                clawAnimation.SetBool("close", false);
            }
        }
    }
}
