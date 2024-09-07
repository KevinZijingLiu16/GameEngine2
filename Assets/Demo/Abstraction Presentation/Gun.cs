using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gun : Weapon
{
    // Implementation of the Use method for the gun, giving it a unique behavior
    public override void Use()
    {
        Debug.Log("Shooting the gun!");
    }

    // Gun can use the default Reload method from Weapon or override it
    public override void Reload()
    {
        Debug.Log("Reloading the gun with bullets...");
    }
}
