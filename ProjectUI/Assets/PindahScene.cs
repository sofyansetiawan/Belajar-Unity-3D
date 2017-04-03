using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PindahScene : MonoBehaviour {
	public string ButtonSound;
	public string namaScene;

	public void PindahKeScene(){
		AudioSource buttonSound = GameObject.Find(ButtonSound).GetComponent<AudioSource> ();
		buttonSound.PlayOneShot (buttonSound.clip);

		Scene sceneIni = SceneManager.GetActiveScene ();

		if(sceneIni.name != namaScene){
			SceneManager.LoadScene (namaScene);
		}
	}

}
