using UnityEngine;
using System.Collections;

public class Keluar : MonoBehaviour {

	public AudioSource ButtonSound;

	public void KeluarDariGame(){
		AudioSource buttonSound = ButtonSound.GetComponent<AudioSource> ();
		buttonSound.PlayOneShot (buttonSound.clip);
		Application.Quit ();
	}
}
