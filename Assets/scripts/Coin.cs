using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
   [Range (0, 1)]public int SerialID;
    [Range (-100, 100)] public int Points=10;
    private void Start() {
      GMScore.Score.Points(Points);
    }
    

    void OnTriggerEnter(Collider other){
		if (other.tag == "Player"){
      if (SerialID==0){
    Destroy (this.gameObject);
    GM_sound.GMsound.SoundCoin(0);
    GMScore.Score.Counter(Points);
    }if (SerialID==1){
    Destroy (this.gameObject);
    GM_sound.GMsound.SoundCoin(1);
    GMScore.Score.Counter(Points);
    }
  }
}  

}
