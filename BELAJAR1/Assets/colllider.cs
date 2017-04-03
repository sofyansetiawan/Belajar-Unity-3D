using UnityEngine;
using System.Collections;

public class colllider : MonoBehaviour {

	void OnCollisionEnter (){
		Debug.Log ("Enter");
	}

	void OnCollisionStay(){
		Debug.Log ("Stay");
	}

	void OnCollisionExit(){
		Debug.Log ("Exit");
	}
}
