using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public Camera kamera1;
	public Camera kamera2;

	void Start(){
		kamera2.enabled = false;
		kamera1.enabled = true;
	}

	void Update () {
		if (Input.GetKeyUp ("o")) {
			kamera1aktif ();
		} 
		else if (Input.GetKeyUp ("p")) {
			kamera2aktif ();
		}
	}

	public void kamera1aktif() {
		kamera2.enabled = false;
		kamera1.enabled = true;
	}

	public void kamera2aktif() {
		kamera2.enabled = true;
		kamera1.enabled = false;
	}
}
