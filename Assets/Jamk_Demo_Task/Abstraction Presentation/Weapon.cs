using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    // Abstract method that must be implemented by derived classes. No logic is provided here.
    public abstract void Use();

    // Non-abstract method with default implementation
    public virtual void Reload()
    {
        Debug.Log("Reloading weapon...");
    }
}
