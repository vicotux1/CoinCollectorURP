using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColisions : MonoBehaviour{

public Ball_move move;
//public 
//public GMLives Lives;
void OnTriggerEnter(Collider other){
        if (other.tag == "Enemy"){
			move.Reset();
			Debug.Log("trigger");
			  GMLives.GM_Lives.life(-1);
			}
		}

}
