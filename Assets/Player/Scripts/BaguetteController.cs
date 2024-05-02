using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaguetteController : MonoBehaviour{

    public float speed = 10.0f;
    private Stats stats ;
    private ParticleSystem psGrass;
    public GameObject psg ;
    void Start(){
        stats = GetComponent<Stats>();
        psGrass = psg.GetComponent<ParticleSystem>();
    }
    void Update(){
        Vector3 dir = Vector3.zero;
        bool actPSG = false;
        if (Input.GetKey(KeyCode.W)){
            dir += transform.right;
            actPSG = true;
        }
        if (Input.GetKey(KeyCode.S)){
            dir -= transform.right;
            actPSG = true;
        }
        if (Input.GetKey(KeyCode.A)){
            dir += transform.forward;
            actPSG = true;
        }
        if (Input.GetKey(KeyCode.D)){           
            dir -= transform.forward;
            actPSG = true;       
        }
        if (Input.GetKeyDown(KeyCode.F)){
           stats.takeDamage(10);
        }
            
        transform.Translate( dir * speed * Time.deltaTime);

        if (actPSG){
            psGrass.Play();
        }else{  
            psGrass.Stop();
        }
    }
}
