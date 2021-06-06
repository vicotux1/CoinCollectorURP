using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour{
    [SerializeField] PlayerMove Player;
    private float movementY,movementX;

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;

        
    } 
    private void FixedUpdate(){
        Player.Movement(movementX, movementY);
    }
}
