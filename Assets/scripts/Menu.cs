using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class Menu : MonoBehaviour
{
	public AudioSource Audio;
	[Range(1,2)][SerializeField]int _MenuID=1;
	public AudioClip Button;
	public GameObject mainmenu,options;
	private void Awake(){
		cursorfalse();
		if(_MenuID==1){
			mainmenuOn();
		}if(_MenuID==2){
			optionsOn();
		}
	}
	
	public void mainmenuOn(){
		mainmenu.SetActive(true);
		options.SetActive(false);
		
	}
	public void optionsOn(){
		mainmenu.SetActive(false);
		options.SetActive(true);
		
	}
			
		
	public void cursorF(string url){
		Application.OpenURL(url);
	}
	public void buttonsound() {
		Audio.clip =Button;
		Audio.Play();
		cursortrue();
	}
	public void Shadows(int qualityIndex){
		
		if(qualityIndex==0){
			QualitySettings.shadowResolution=ShadowResolution.Low;
		}
		if(qualityIndex==1){
			QualitySettings.shadowResolution=ShadowResolution.Medium;
		}
		if(qualityIndex==2){
			QualitySettings.shadowResolution=ShadowResolution.High;
		}
			if(qualityIndex==3){
			QualitySettings.shadowResolution=ShadowResolution.VeryHigh;
			 
		}
	}
	public void vSync(int qualityIndex){
		
		if(qualityIndex==0){
			QualitySettings.vSyncCount = 0;
		}
		if(qualityIndex==1){
			QualitySettings.vSyncCount = 1;
		}
		if(qualityIndex==2){
			QualitySettings.vSyncCount = 2;
		}
	}
		
		

	public void cursortrue(){
		Cursor.visible = true;
	}
	public void cursorfalse(){
		Cursor.visible = false;
	}	
	public void SetQuality(int qualityIndex){
		if(qualityIndex==0){
			QualitySettings.SetQualityLevel(2);
			}
		if(qualityIndex==1){
			QualitySettings.SetQualityLevel(1);
			}
		if(qualityIndex==2){
			QualitySettings.SetQualityLevel(0);
			}	
		 
		}
		public void fullScreen(bool Fullscreen){
	Screen.fullScreen = Fullscreen;
	}





}
