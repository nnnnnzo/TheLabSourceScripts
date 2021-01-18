using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slide : MonoBehaviour {
 
     public Vector3 pointA, pointB;
     float speed;
     bool lerp;
     


 
     void Update()
     {
        if (Input.GetButton("Fire1"))
        {
            lerp = true;
        }
        if(lerp){
            transform.position = Vector3.Lerp(pointA,pointB, Time.deltaTime);
        }
        
     }

}
