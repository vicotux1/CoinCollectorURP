using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallInput: MonoBehaviour{
    [SerializeField] Ball_move Player;
    private float movementY,movementX;

    private void OnMove(float moveX,float moveY)
    {

        movementX = moveX;
        movementY = moveY;

        
    } 
    private void FixedUpdate(){
        Player.Move(movementX, movementY);
    }
}
