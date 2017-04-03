using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PindahPanel : MonoBehaviour {

	public AudioSource buttonSound;
	public GameObject PanelAwal;
	public GameObject PanelTujuan;

	public void GantiKePanelbaru(){
		buttonSound.PlayOneShot (buttonSound.clip);
		PanelAwal.SetActive (false);
		PanelTujuan.SetActive (true);
	}
}
