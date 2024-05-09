using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour{

    private Transform focus ;
    private CinemachineVirtualCamera vc ;
    public float velocity = 100.0f;
    void Start()    {
        vc = GetComponent<CinemachineVirtualCamera>();
        focus = vc.Follow;    
    }

    void Update()    {
        if(Input.GetKey(KeyCode.Q)){
            focus.Rotate(Vector3.up,velocity * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.E)){
            focus.Rotate(Vector3.up,-velocity * Time.deltaTime);
        }
        //if(Input.mouseScrollDelta.y < 0){
           
           
        //}



    }
}
