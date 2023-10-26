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

    [Header("Animator Shit")]
    public Animation clawAnimation;
    public static bool craneClose;
    void Start()
    {
        stateMachine = new StateMachine();
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
                //Bikin kode buat enable bool animasi dia nurunin claw-nya

                //Bikin checker apabila claw mendeteksi objek, akan pindah ke state close
                if (currentState != State.Close)
                {
                    currentState = State.Close;
                    stateMachine.ChangeState(currentState);
                    stateMachine.Update();
                }

                /*//Bikin kode yang pindahin dia ke state rising
                currentState = State.Rise;
                stateMachine.ChangeState(currentState);
                stateMachine.Update();*/
            }
        }
    }
}
