using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateEnum;

public class StateMachine
{
    private IState currentState;

    public void ChangeState(State newState)
    {
        if(currentState!= null)
        {
            currentState.ExitState();
        }

        switch (newState)
        {
            case State.Open:
                currentState = new OpenState();
                break;
            case State.Close:
                currentState = new CloseState();
                break;
            case State.Rise:
                currentState = new RiseState();
                break;
        }
        currentState.EnterState();
    }

    public void Update()
    {
        if (currentState != null)
        {
            currentState.UpdateState();
        }
    }
}
