using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public bool GravityOn = true;
    // Start is called before the first frame update
    void Awake() {
        Physics.gravity = new Vector3(0, -5.0F, 0);
    }
   public void GravityButton(){
       if (GravityOn == true){
           //Physics.gravity = new Vector3(0, -0.15f, 0);
           Physics.gravity = new Vector3(0, 0.3F, 0);
           GravityOn = false;
       }
       else if (GravityOn == false){
           Physics.gravity = new Vector3(0, -5.0F, 0);
           GravityOn = true;
       }
   }
}
