using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : IState
{
    public float positionX;
    public float positionZ;

    public static bool moveXNow = true;
    
    public void EnterState()
    {

    }

    public void UpdateState()
    {
        if(moveXNow == true)
        {
            MoveX(10f);
        }else if(moveXNow == false)
        {
            MoveZ(10f);
        }
    }

    public void ExitState()
    {
        moveXNow = !moveXNow;
    }

    public void MoveX(float distance)
    {
        positionX += distance;
    }

    public void MoveZ(float distance)
    {
        positionZ += distance;
    }
}

