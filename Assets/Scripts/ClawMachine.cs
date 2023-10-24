using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateEnum;

public class ClawMachine : MonoBehaviour
{
    private StateMachine stateMachine;
    private State currentState;

    void Start()
    {
        stateMachine = new StateMachine();
        currentState = State.Open;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*Debug.Log("Helo World");*/
        currentState = State.Open;
        stateMachine.ChangeState(currentState);
        stateMachine.Update();
        
    }
}
