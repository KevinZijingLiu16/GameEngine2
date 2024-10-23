using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackingState : PlayerBaseState
{
    private float previousFrameTime;
    private bool alreadyApplyForce;

    private Attack attack;
    public PlayerAttackingState(PlayerStateMachine stateMachine, int attckIndex) : base(stateMachine) 
    {
        attack = stateMachine.Attacks[attckIndex];
    }

    public override void Enter()
    {
        stateMachine.Weapon.SetAttack(attack.Damage);
        stateMachine.Animator.CrossFadeInFixedTime(attack.AnimationName, attack.TransitionDuration);
    }
    public override void Tick(float deltaTime)
    {
        Move(deltaTime);
        FaceTarget();

        float normalizedTime = GetNormalizedTime();

        if (normalizedTime >= previousFrameTime && normalizedTime < 1)
        {
            if (normalizedTime >= attack.ForceTime)
            {
                TryApplyForce();
            }

            if (stateMachine.InputReader.IsAttacking)
            {
                TryComboAttack(normalizedTime);
            }
        }
        else
        {
            // go back to locomotion state

            if (stateMachine.Targeter.CurrentTarget != null)
            {
                stateMachine.SwitchState(new PlayerTargetingState(stateMachine));
            }
            else
            {
                stateMachine.SwitchState(new PlayerFreeLookState(stateMachine));
            }
        }
        previousFrameTime = normalizedTime;
    }

   

    public override void Exit()
    {
       
    }

    private void TryComboAttack(float normalizedTime)
    {
        if (attack.ComboStateIndex == -1) { return; }

        if (normalizedTime < attack.ComboAttackTime)
        {
            return;
        }

        stateMachine.SwitchState(new PlayerAttackingState(stateMachine, attack.ComboStateIndex));
    }

    private void TryApplyForce()
    {
        if (alreadyApplyForce) { return; }

        stateMachine.ForceReceiver.AddForce(stateMachine.transform.forward * attack.Force);

        alreadyApplyForce = true;
    }

    private float GetNormalizedTime()
    {
        AnimatorStateInfo currentInfo = stateMachine.Animator.GetCurrentAnimatorStateInfo(0);
        AnimatorStateInfo nextInfo = stateMachine.Animator.GetNextAnimatorStateInfo(0);

        if(stateMachine.Animator.IsInTransition(0) && nextInfo.IsTag("Attack"))
        {
            return nextInfo.normalizedTime;
        }

        else if(!stateMachine.Animator.IsInTransition(0) && currentInfo.IsTag("Attack"))
        {
            return currentInfo.normalizedTime;
        }

        else
        {
            return 0;
        }

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
