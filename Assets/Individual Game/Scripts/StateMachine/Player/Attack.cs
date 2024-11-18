using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Attack 
{
    [field: SerializeField] public string AnimationName { get; private set; } //[field: SerializeField] is used to make the private set property visible in the Unity Editor, so that the value can be set from the editor.

    [field: SerializeField] public float TransitionDuration { get; private set; }

    [field: SerializeField] public int ComboStateIndex { get; private set; } = -1; // ComboStateIndex is set to -1 by default, so the final attack won't combo into anything. for the other attacks, it will be set to the index of the next attack in the array

    [field: SerializeField] public float ComboAttackTime { get; private set; }

    [field: SerializeField] public float ForceTime { get; private set; }

    [field: SerializeField] public float Force { get; private set; }

    [field: SerializeField] public int Damage { get; private set; }

    [field: SerializeField] public float Knockback { get; private set; }




}
