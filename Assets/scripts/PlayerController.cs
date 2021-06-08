
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;

    private Rigidbody rb;

    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Awake(){
        rb = GetComponent<Rigidbody>();
    }

    private void OnMove(){

        movementX = Input.GetAxis("Horizontal");
        movementY = Input.GetAxis("Vertical");

    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }

}
