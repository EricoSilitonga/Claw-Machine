using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateEnum;

public class ClawMachine : MonoBehaviour
{
    private StateMachine stateMachine;
    private State currentState;

    private bool moveXNow;
    private bool moveZNow;
    void Start()
    {
        stateMachine = new StateMachine();
        currentState = State.Idle;
        moveXNow = true;
        moveZNow = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentState = State.Moving;
        }
    }
}
