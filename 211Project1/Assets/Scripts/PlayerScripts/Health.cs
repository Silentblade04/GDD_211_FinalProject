using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxHealth = 5;
    public int currentHealth;
    void Start()
    {
        currentHealth = maxHealth;
    }
    void takeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0) { 
        //Play Dead Animation
        //Set isDead = true;
        //Lock Player control
        //Activate Respawn or Return to Title Canvas
        }
    }

}
