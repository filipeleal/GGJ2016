using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {

	public Transform resetPlayer;

	void OnTriggerEnter(Collider collider){
		if (collider.tag != "Player")
			Destroy (collider.gameObject);
		else
			collider.transform.position = resetPlayer.position;
	}
}
