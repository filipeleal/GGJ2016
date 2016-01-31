using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ExitLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Quit")) {
			SceneManager.LoadScene ("Menu");
		}
	}
}
