using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CubeMove : MonoBehaviour
{
    public float dragSpeed = 1f;
    Vector3 lastMousePos;
    Vector3 pivot = new Vector3 (Screen.width/2, Screen.height/3, 0);
    public Rigidbody rb;
    public Rigidbody snowball;
    public float floatPi = (float)Math.PI;


    void Update(){
        if (Input.GetMouseButton(0)){
        //move to the direction of mouse 
             Vector3 delta = Input.mousePosition - pivot;
            Vector3 pos = transform.position;
            double norm = Math.Sqrt(delta.x * delta.x + delta.y * delta.y);
            pos.x += delta.x / (float)norm * dragSpeed;
            pos.z += delta.y / (float)norm * dragSpeed;
            transform.position = pos;
            lastMousePos = Input.mousePosition;
        //stare the direction of the mouse
           //Vector3 pos2 = Camera.main.WorldToScreenPoint(transform.position);
            float angle = Mathf.Atan2(delta.y, delta.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(360 - angle, Vector3.up);

            
            
            //snowball.transform.position = 
        }
        if (Input.GetMouseButtonUp(0)){
            
        }
       
    }
}
