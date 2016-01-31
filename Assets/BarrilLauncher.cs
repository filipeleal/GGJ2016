using UnityEngine;
using System.Collections;

public class BarrilLauncher : MonoBehaviour {

	public int simultaneous = 1;
	public int[] order;
	public Transform[] LauncherPoints;

	public GameObject Barril;

	public float TimeBetweenLauches = 1f;

	private float timeToInstantiate = 0;

	private int orderIndex = 0;

	// Use this for initialization
	void Start () {
		if (LauncherPoints == null || LauncherPoints.Length == 0)
			return;

		if (simultaneous > LauncherPoints.Length)
			simultaneous = LauncherPoints.Length;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (timeToInstantiate <= 0) {

			for (var i = 0; i < simultaneous; i++) {

				var clone = Instantiate (Barril, LauncherPoints [order [orderIndex]].position, Quaternion.Euler (new Vector3 (0, 0, 90)));
				(clone as GameObject).tag = tag;
				timeToInstantiate = TimeBetweenLauches;
				orderIndex++;
				if (orderIndex >= order.Length)
					orderIndex = 0;
			}
		}
		timeToInstantiate -= Time.deltaTime;
	}
}
