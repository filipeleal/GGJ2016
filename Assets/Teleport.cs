using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {


	public Transform ToPoint;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		other.gameObject.transform.position = ToPoint.position;
	}
}
