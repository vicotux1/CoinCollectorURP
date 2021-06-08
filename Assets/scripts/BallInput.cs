using System;
using UnityEngine;

    public class BallInput: MonoBehaviour{
        [SerializeField] string InputX="Horizontal", InputY="Vertical", Jump="Fire1";
        //[SerializeField]
        private Ball_move ball; 

        private Vector3 move;

        private Transform cam; 
        private Vector3 camForward; 
        private bool jump;

        private void Awake(){
            if (Camera.main != null){
                cam = Camera.main.transform;
            }
        ball= GetComponent<Ball_move>();    
        }


        private void Update(){
        float h = Input.GetAxis(InputX);
        float v = Input.GetAxis(InputY);
        jump = Input.GetButton(Jump);

        if (cam != null){
                camForward = Vector3.Scale(cam.forward, new Vector3(1, 0, 1)).normalized;
                move = (v*camForward + h*cam.right).normalized;
            }
            else{
                move = (v*Vector3.forward + h*Vector3.right).normalized;
            }
        }


        private void FixedUpdate() {
        
            ball.Move(move, jump);
            jump = false;
        }
    }
