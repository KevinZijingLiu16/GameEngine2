using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackingState : PlayerBaseState
{
    private Attack attack;
    public PlayerAttackingState(PlayerStateMachine stateMachine, int attckId) : base(stateMachine) 
    {
        attack = stateMachine.Attacks[attckId];
    }

    public override void Enter()
    {
        stateMachine.Animator.CrossFadeInFixedTime(attack.AnimationName, 0.1f);
    }
    public override void Tick(float deltaTime)
    {
       
    }
    public override void Exit()
    {
       
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
