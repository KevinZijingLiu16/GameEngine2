using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    private int health;



    // Start is called before the first frame update
    private void Start()
    {
        health = maxHealth; 
    }

    public void DealDamage(int damage)
    {
        
        if (health == 0)
        {
            return;
        }

        health = Mathf.Max(health - damage, 0); //mathf.max is used to prevent health from going below 0 by return the largest value between 0 and health - damage

        Debug.Log("Health: " + health);
    }

 

}
