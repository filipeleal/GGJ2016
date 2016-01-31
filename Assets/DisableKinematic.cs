using UnityEngine;
using System.Collections;

public class DisableKinematic : MonoBehaviour {

	public Rigidbody objectToDisable;
	// Use this for initialization

	void OnTriggerEnter(Collider collider){
		if (collider.tag == "MainCamera") {
			objectToDisable.isKinematic = false;
		}
	}
}
