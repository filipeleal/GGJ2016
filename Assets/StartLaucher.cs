using UnityEngine;
using System.Collections;

public class StartLaucher : MonoBehaviour {

	public BarrilLauncher[] lauchersToStart;

	void OnTriggerEnter(Collider collider){
		if (collider.tag == "Player") {
			foreach (var laucher in lauchersToStart) {
				laucher.enabled = true;
			}
		}
	}
}
