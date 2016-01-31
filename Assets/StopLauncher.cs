using UnityEngine;
using System.Collections;

public class StopLauncher : MonoBehaviour {

	public BarrilLauncher[] lauchersToStop;

	void OnTriggerEnter(Collider collider){
		if (collider.tag == "Player") {
			foreach (var laucher in lauchersToStop) {
				laucher.enabled = false;
			}
		}
	}
}
