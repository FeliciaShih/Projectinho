using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliveEntity : MonoBehaviour
{
    [SerializeField]protected float baseHealth, currentHealth;
    
    public void takeDamage(float damage){
        currentHealth -= damage;
    }
    
}
