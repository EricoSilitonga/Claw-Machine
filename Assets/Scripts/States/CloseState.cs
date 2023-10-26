using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseState : IState
{
    public void EnterState()
    {
        Debug.Log("CLOSING STATE");
    }

    public void UpdateState()
    {
        /*if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("ENTERING CLOSING STATE");
        }*/
    }

    public void ExitState()
    {

    }
}
