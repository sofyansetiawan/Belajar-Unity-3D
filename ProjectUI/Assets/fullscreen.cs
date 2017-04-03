using UnityEngine;
using System.Collections;

public class fullscreen : MonoBehaviour {

	public void fullscreenOnOff(){

		if(Screen.fullScreen == true){
			Screen.fullScreen = false;
		}else{
			Screen.fullScreen = true;
		}
	}
}
