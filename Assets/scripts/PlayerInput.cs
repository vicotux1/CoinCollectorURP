using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour{
    [SerializeField] PlayerMove Player;
    private float movementY,movementX;

    private void OnMove(){

        movementX = Input.GetAxis("Horizontal");
        movementY = Input.GetAxis("Vertical");

        
    } 
    private void FixedUpdate(){
        Player.Movement(movementX, movementY);
    }
}
