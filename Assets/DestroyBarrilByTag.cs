using UnityEngine;
using System.Collections;

public class DestroyBarrilByTag : MonoBehaviour {

	public string TagToDestroy;

	void OnTriggerEnter(Collider collider){
		if (collider.tag == TagToDestroy)
			Destroy (collider.gameObject);
	}
}
