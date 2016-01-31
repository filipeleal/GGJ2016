using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FollowPath : MonoBehaviour {

	public PathDefinition path;
	public float speed = 1;
	public float maxDistanceToGoal = .1f;

	private IEnumerator<Transform> _currentPoint;

	// Use this for initialization
	void Start () {
		if (path == null)
			return;

		_currentPoint = path.GetPathEnumerator ();

		_currentPoint.MoveNext ();

		if (_currentPoint.Current == null)
			return;

		transform.position = _currentPoint.Current.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (_currentPoint == null || _currentPoint.Current == null)
			return;

		transform.position = Vector3.MoveTowards (transform.position, _currentPoint.Current.position, Time.deltaTime * speed); 

		var distance = Vector3.Distance (transform.position, _currentPoint.Current.position);

		if (distance < maxDistanceToGoal)
			_currentPoint.MoveNext ();
	}
}
