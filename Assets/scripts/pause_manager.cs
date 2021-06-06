using UnityEngine; 
using System.Collections; 
using UnityEngine.UI;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif
public class pause_manager : MonoBehaviour {
    public Canvas canvasPause;
	
	void Start(){
	canvasPause.enabled = false;
	Time.timeScale = 1;
	//Cursor.visible = false;
	}
	void Update(){
		
		}
    public void Pause(){
        canvasPause.enabled = !canvasPause.enabled;
        Time.timeScale = Time.timeScale == 0 ? 1: 0;
		}
public void Quit(){
     #if UNITY_EDITOR 
    EditorApplication.isPlaying = false;
    #else
    Application.Quit();
	#endif
	}
}
