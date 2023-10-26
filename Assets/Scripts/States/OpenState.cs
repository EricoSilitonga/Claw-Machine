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
        float verticalInput = Input.GetAxisRaw("Vertical");
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        Vector2 inputDirection = new Vector2(horizontalInput, verticalInput).normalized;

        float moveX = inputDirection.x * ClawMachine.craneSpeed;
        float moveZ = inputDirection.y * ClawMachine.craneSpeed;

        MoveCrane(moveX, moveZ);
    }

    public void MoveCrane(float speedX, float speedZ)
    {
        ClawMachine.thisGo.transform.Translate(speedX, ClawMachine.thisGo.transform.position.y , speedZ);
        Debug.Log("Claw Machine is running");
    }

    public void ExitState()
    {
       
    }
}
