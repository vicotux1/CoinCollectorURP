using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColisions : MonoBehaviour{

public PlayerMove move;
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
