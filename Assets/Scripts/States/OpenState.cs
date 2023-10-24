using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenState : IState
{
    private GameObject clawGo;

    public void EnterState()
    {
        Debug.Log("Claw Machine is Opening..");
    }

    public void UpdateState()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Claw Machine is Moving Up");
        }else if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Claw Machine is Moving Down");
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Claw Machine is Moving Left");
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Claw Machine is Moving Right");
        }
    }

    public void ExitState()
    {
       
    }
}
