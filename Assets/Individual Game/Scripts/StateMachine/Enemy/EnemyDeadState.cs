using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeadState : EnemyBaseState
{
    public EnemyDeadState(EnemyStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
       //toggle ragdoll
       stateMachine.Ragdoll.ToggleRagdoll(true);
        //disable weapon
        stateMachine.Weapon.gameObject.SetActive(false);
        //disable target component
        GameObject.Destroy(stateMachine.Target);
    }

    public override void Exit()
    {
        
    }

    public override void Tick(float deltaTime)
    {
       
    }

    
}
