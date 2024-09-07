using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponTester : MonoBehaviour
{
    void Start()
    {
        
        Weapon myWeapon = gameObject.AddComponent<Sword>(); //instantiating a Sword object
        myWeapon.Use();   // Expected Console Output: Swinging the sword!
        myWeapon.Reload(); // Expected Console Output: Reloading weapon... (default behavior from Weapon class)


        myWeapon = gameObject.AddComponent<Gun>(); //instantiating a Gun object
        myWeapon.Use();   // Expected Console Output: Shooting the gun!
        myWeapon.Reload(); // Expected Console Output: Reloading the gun with bullets... (overridden behavior)
    }
}
