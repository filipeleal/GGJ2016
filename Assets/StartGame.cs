using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	void Update(){
		if (Input.GetButtonDown ("Quit")) {
			Debug.Log ("Quit");
			Application.Quit ();
		}

		else if (Input.anyKeyDown) {
			SceneManager.LoadScene ("Level1");
		}
	}

	void OnMouseDown(){
		SceneManager.LoadScene ("Level1");
	}
}
