using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenState : IState
{

    public void EnterState()
    {
        Debug.Log("Claw Machine is Opening..");
    }

    public void UpdateState()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector2 inputDirection = new Vector2(horizontalInput, verticalInput).normalized;

        float moveX = inputDirection.x * ClawMachine.craneSpeed;
        float moveZ = inputDirection.y * ClawMachine.craneSpeed;

        MoveCrane(moveX, moveZ);

    }

    public void MoveCrane(float speedX, float speedZ)
    {
        ClawMachine.thisGo.transform.Translate(speedX, 0 , speedZ);
    }

    public void ExitState()
    {
       
    }
}
