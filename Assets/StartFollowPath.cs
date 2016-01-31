using UnityEngine;
using System.Collections;

[RequireComponent(typeof(FollowPath))]
public class StartFollowPath : MonoBehaviour {

	private FollowPath followPath;

	void Awake()
	{
		followPath = GetComponent<FollowPath>();
		followPath.enabled = false;
		Debug.Log (followPath);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {

		if (other.tag != "Player")
			return;

		followPath.enabled = true;
		Debug.Log (followPath.enabled);
	}


}
