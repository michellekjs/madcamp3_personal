using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FollowPlayer : MonoBehaviour
{
    public Vector3 offset;
    public Rigidbody rb;
     Vector3 pivot = new Vector3 (485, 150, 0);
     public float floatPi = (float)Math.PI;
     Vector3 newoffset;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

         Vector3 delta = Input.mousePosition - pivot;
        Vector3 pos = transform.position;
        double norm = Math.Sqrt(delta.x * delta.x + delta.y * delta.y);
        

        float angle = Mathf.Atan2(delta.y, delta.x) * Mathf.Rad2Deg;
            

        
       // transform.rotation = Quaternion.AngleAxis(360 - angle, Vector3.up);
        
        //transform.rotation = Quaternion.AngleAxis(360 - angle, Vector3.up);
        transform.position = (rb.position + offset);
    }
}
