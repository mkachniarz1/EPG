using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtSun : MonoBehaviour {

	[SerializeField]
	private Transform sun;
	
	void Update () {
		transform.LookAt(Vector3.zero);

		// transform.rotation = Quaternion.AxisAngle(Vector3.up, 30 * Time.deltaTime);
	}
}
