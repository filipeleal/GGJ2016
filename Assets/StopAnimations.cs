using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;

public class StopAnimations : MonoBehaviour {

//	public Animator animatorToStop;

	private bool AnyKeyToQuit = false;
	// Use this for initialization
	void Start () {
		AnyKeyToQuit = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (AnyKeyToQuit && Input.anyKeyDown) {
			SceneManager.LoadScene ("Menu");
		}
	}

	void OnTriggerEnter(Collider collider){
		if (collider.tag == "MainCamera") {
//			animatorToStop.enabled = false;
			AnyKeyToQuit = true;
		}
	}
}
