using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Attack 
{
    [field: SerializeField] public string AnimationName { get; private set; } //[field: SerializeField] is used to make the private set property visible in the Unity Editor, so that the value can be set from the editor.
}
