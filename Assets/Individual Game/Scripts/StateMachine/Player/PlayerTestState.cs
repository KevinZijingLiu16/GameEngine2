using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTestState : PlayerBaseState
{
   

    public PlayerTestState(PlayerStateMachine stateMachine) : base(stateMachine) { } 

    public override void Enter()
    {
        
    }

    public override void Tick(float deltaTime)
    {


        Debug.Log(stateMachine.InputReader.MovementValue);

        
    }

    public override void Exit()
    {
        
    }

   
}
