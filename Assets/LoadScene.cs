using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {
	public string scene;
	void OnTriggerEnter(Collider collider){
		if (collider.tag == "Player") {
			SceneManager.LoadScene(scene);
		}
	}
}
