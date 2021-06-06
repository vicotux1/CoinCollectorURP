using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour{
   Rigidbody rb;
   public Vector3 Position_initial;
   public float speed=10.0f;
   //float MovX, MovY;
   private void Awake() {
    //Reset();
    rb = GetComponent<Rigidbody>();
    }
    public void Reset() {
    //Cursor.visible = false;
    rb.velocity=Vector3.zero;
   transform.position=Position_initial;  
    }
    public void Movement(float MovX, float MovY){
    Vector3 move=new Vector3(MovX,transform.position.y,MovY);
    rb.AddForce(move* speed);
    //rb.AddTorque(move* speed);
    }
}
