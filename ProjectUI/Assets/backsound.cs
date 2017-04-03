using UnityEngine;
using System.Collections;

public class backsound : MonoBehaviour {

	public AudioSource Backsound;

	public void backsoundOnOff(){
		AudioSource bgsound = Backsound.GetComponent<AudioSource> ();

		if(bgsound.mute == true){
			bgsound.mute = false;
		}else{
			bgsound.mute = true;
		}
	}
}
