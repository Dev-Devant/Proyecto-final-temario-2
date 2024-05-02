using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour{

    private Transform focus ;
    private CinemachineVirtualCamera vc ;
    void Start()    {
        vc = GetComponent<CinemachineVirtualCamera>();
        focus = vc.Follow;    
    }

    void Update()    {
        if(Input.GetKey(KeyCode.Q)){
            focus.Rotate(Vector3.up,50.0f * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.E)){
            focus.Rotate(Vector3.up,-50.0f* Time.deltaTime);
        }
        //if(Input.mouseScrollDelta.y < 0){
           
           
        //}



    }
}
