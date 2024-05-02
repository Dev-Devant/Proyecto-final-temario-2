using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour{
    
    public float Speed = 10;
    public float Health = 100;
    public float HealthRegen = 1;
    public float maxHealth = 100;
    public bool alive = true;
       
    
    void Start()    {
        
    }

    void Update()    {
        
    }

    public float takeDamage( float dmg){

        if(!alive){
            return 0;
        }
    
        Health -= dmg; 
        
        if(Health < 0){
            Health = 0;
            alive = false;
        }
        if( Health > maxHealth){
            Health = maxHealth;
        }

        return Health;
    }

}
