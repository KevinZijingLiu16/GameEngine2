using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerBaseState : State
{
    protected PlayerStateMachine stateMachine;

    public PlayerBaseState(PlayerStateMachine stateMachine) // Constructor, takes the reference to the state machine
    {
        this.stateMachine = stateMachine;
    }
}
