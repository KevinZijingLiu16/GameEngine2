using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sword : Weapon
{
    // Implementation of the Use method for the sword and gives it a unique behavior
    public override void Use()
    {
        Debug.Log("Swinging the sword!");
    }

    // Sword doesn't need to override Reload since it may not apply, but it can if needed
}

