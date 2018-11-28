using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectOnPlane : MonoBehaviour
{
	[SerializeField]
	private Transform plane;

	private void OnDrawGizmos ()
	{
		// Gizmos.DrawLine(Vector3.zero, transform.position);

		float angle = Vector3.Angle (plane.up, transform.position);
		Vector3 down = plane.up * Mathf.Sin ((90 - angle) * Mathf.Deg2Rad) * transform.position.magnitude;

		Debug.DrawLine (transform.position, transform.position - down, Color.red);

		// Debug.DrawLine(transform.posi)
	}
}