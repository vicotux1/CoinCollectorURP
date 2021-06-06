using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class menu2 : MonoBehaviour
{
    public void Quit(){
        #if UNITY_EDITOR 
        EditorApplication.isPlaying = false;
        #else
        Application.Quit();
		#endif
		}
    public void LevelSelect(string name){ 
		
		SceneManager.LoadScene (name);
		}
    
}
