using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColisions : MonoBehaviour{

[SerializeField]private Ball_move move;
private void Awake() {
	//move= GetComponent<Ball_move>();
}
void OnTriggerEnter(Collider other){
        if (other.tag == "Enemy"){
			move.Reset();
			Debug.Log("trigger");
			GMLives.GM_Lives.life(-1);
			}
		}

}