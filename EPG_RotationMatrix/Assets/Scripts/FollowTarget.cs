using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour {

	[SerializeField]
	private Transform target;

	void Update () {
		this.transform.LookAt (target);
	}
}