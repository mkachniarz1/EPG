using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Rigidbody))]
public class FlyAround : MonoBehaviour
{
	public Vector3 startVelocity = Vector3.forward;

	[SerializeField]
	private Rigidbody sun;
	[SerializeField]
	private float G = 2f;

	private float numSubsteps = 100;

	private new Rigidbody rigidbody;
	private Vector3 position;
	private Vector3 velocity;

	private void Start ()
	{
		rigidbody = GetComponent<Rigidbody> ();
		rigidbody.velocity = startVelocity;
		velocity = startVelocity;
		position = transform.position;
	}

	void FixedUpdate ()
	{
		{

			for(int i = 0; i < numSubsteps; i++){


			}
			Vector3 distance = sun.position - transform.position;

			float force = G * sun.mass * rigidbody.mass / Mathf.Pow (distance.magnitude, 2);

			rigidbody.AddForce (force * distance.normalized);
			 Vector3 forceV = force * distance.normalized;
			 Vector3 impulse = forceV * Time.deltaTime;
			//  rigidbody.velocity += impulse / rigidbody.mass;

			// Debug.DrawRay (transform.position, forceV, Color.green);

			// Debug.DrawRay (transform.position, rigidbody.velocity, Color.cyan);
			// Debug.DrawRay (transform.position, rigidbody.velocity + force * distance.normalized, Color.cyan);

			Debug.DrawRay(transform.position, -rigidbody.velocity.normalized , Color.white, 1f);

			// position += rigidbody.velocity * Time.deltaTime;
		}
		{
			// Vector3 dist = sun.position - this.transform.position;
			// float force = G * (sun.mass * rigidbody.mass) / Mathf.Pow (dist.magnitude, 2);

			// rigidbody.AddForce (force * dist.normalized);
			// transform.position = position;
			// rigidbody.velocity = velocity;
		}
	}
	// Vector3 distance = sun.position - transform.position;
	// force = (GetComponent<Rigidbody> ().mass + sun.mass) / Mathf.Pow (distance.magnitude, 2);

	// transform.RotateAround (sun.transform.position, sun.transform.up, 100 * Time.deltaTime);

	// GetComponent<Rigidbody> ().AddForce (distance.normalized * force);
}