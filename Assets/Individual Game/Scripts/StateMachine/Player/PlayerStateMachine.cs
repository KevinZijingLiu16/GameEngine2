using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{

    [field: SerializeField] public InputReader InputReader { get; private set; }
    //     [field: SerializeField] make the property become a field then be serializable
    private void Start()
    {
        SwitchState(new PlayerTestState(this));
    }

   
}
