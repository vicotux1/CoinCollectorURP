using System;
using UnityEngine;

    public class Ball_move : MonoBehaviour
    { 
    #region "Variables"
        [SerializeField] private float m_MovePower = 5
        ,m_MaxAngularVelocity = 25,m_JumpPower = 2; 
        private const float k_GroundRayLength = 1f;
        [SerializeField] private Vector3 Position_initial;
        [SerializeField] 
        Rigidbody m_Rigidbody;
    #endregion

        private void Awake(){
            Reset();
            //m_Rigidbody = GetComponent<Rigidbody>();
            GetComponent<Rigidbody>().maxAngularVelocity = m_MaxAngularVelocity;
        }
    public void Reset() {
    Cursor.visible = false;
    m_Rigidbody.velocity=Vector3.zero;
   transform.position=Position_initial;  
    }


    public void Move(Vector3 moveDirection, bool jump){
    m_Rigidbody.AddTorque(new Vector3(moveDirection.z, 0, -moveDirection.x)*m_MovePower);
    if (Physics.Raycast(transform.position, -Vector3.up, k_GroundRayLength) && jump){
    m_Rigidbody.AddForce(Vector3.up*m_JumpPower, ForceMode.Impulse);
    }
        }
    }
