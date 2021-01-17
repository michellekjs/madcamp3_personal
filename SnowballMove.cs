using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SnowballMove : MonoBehaviour
{
    public Rigidbody snowball ;
    Vector3 pivot = new Vector3 (Screen.width/2, Screen.height/3, 0);
    public Rigidbody cube;
    bool m_oneTime = true;
    bool s=true;


    void FixedUpdate(){
      
        
    }
    

    // Update is called once per frame
    void Update()
    {
      //마우스가 가리키고 잇는 방향
        

        if(Input.GetMouseButton(0)){
            snowball.transform.localScale += new Vector3((float)0.01,(float)0.01,(float)0.01);
        }
    
        //cube.velocity
        if (Input.GetMouseButtonUp(0)){
            Vector3 delta = Input.mousePosition - pivot; 
            Vector3 pos = transform.position; 
            double norm = Math.Sqrt(delta.x * delta.x + delta.y * delta.y);
            pos.x += delta.x / (float)norm ;
            pos.z += delta.y / (float)norm ;
            transform.position = pos + new Vector3(pos.x*(float)0.1, 0, pos.z*(float)0.1);

            FixedJoint fixedJoint = GetComponent<FixedJoint>();
            Destroy(fixedJoint);


            snowball.AddForce(Input.mousePosition.x*20f,0,Input.mousePosition.z*20f);
        
            if (m_oneTime){
                Instantiate(snowball, cube.transform.position, cube.transform.rotation);
                m_oneTime = false;
            }
            //한번만 스노우볼 다시 만들어냄
        }

        /*
        if(Input.GetMouseButtonDown(0)){
            if (s){
                snowball.gameObject.AddComponent<FixedJoint>();
                snowball.GetComponent<FixedJoint>().connectedBody=cube;
                s=false;
            }
            //한번만 다시연결
            
        }
        */
        
        
    
    }
}
