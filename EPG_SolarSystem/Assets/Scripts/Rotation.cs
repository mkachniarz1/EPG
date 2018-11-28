using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
	[SerializeField]
	private float rotationSpeed = 10f;
	private float angle;

	private void Start()
	{
		angle = 0;
	}
	void Update ()
	{
		angle += Time.deltaTime * rotationSpeed;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.up);
	}
}