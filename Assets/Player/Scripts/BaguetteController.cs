using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BaguetteController : MonoBehaviour{

    public float speed = 10.0f;
    private Stats stats ;
    private ParticleSystem psGrass;
    public GameObject psg ;
    public GameObject control;
    public GameObject character;
    void Start(){
        stats = GetComponent<Stats>();
        psGrass = psg.GetComponent<ParticleSystem>();
    }
    void Update(){
        Vector3 dir = Vector3.zero;
        bool actPSG = false;
        if (Input.GetKey(KeyCode.W)){
            dir += control.transform.forward;
            actPSG = true;
        }
        if (Input.GetKey(KeyCode.S)){
            dir -= control.transform.forward;
            actPSG = true;
        }
        if (Input.GetKey(KeyCode.A)){
            dir -= control.transform.right;
            actPSG = true;
        }
        if (Input.GetKey(KeyCode.D)){           
            dir += control.transform.right;
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
