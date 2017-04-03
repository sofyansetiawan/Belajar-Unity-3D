using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PindahPanel : MonoBehaviour {
	public GameObject PanelAwal;
	public GameObject PanelTujuan;

	public void GantiKePanelBaru () {
		PanelAwal.SetActive (false); 
		PanelTujuan.SetActive (true);
	}
} 
