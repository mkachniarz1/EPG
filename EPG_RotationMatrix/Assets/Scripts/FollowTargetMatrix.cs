using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTargetMatrix : MonoBehaviour
{

	[SerializeField]
	private Transform target;

	void Update ()
	{
		Matrix3x3 rotation = new Matrix3x3 ();
		Vector3 up = transform.right;
		rotation.SetXRotation (30);

	}
}
public enum AxisId
{
	x,
	y,
	z
}
public struct Matrix3x3
{
	public float m11;
	public float m12;
	public float m13;
	public float m21;
	public float m22;
	public float m23;
	public float m31;
	public float m32;
	public float m33;

	public Matrix3x3 Rotate (float angleInDeg, AxisId axisId)
	{
		switch (axisId)
		{
			case AxisId.x:
				return SetXRotation (angleInDeg);
			case AxisId.y:
				return SetYRotation (angleInDeg);
			case AxisId.z:
				return SetZRotation (angleInDeg);
			default:
				return new Matrix3x3 ();
		}
	}

	public Matrix3x3 SetXRotation (float angle)
	{
		var matrix = new Matrix3x3 ();
		float angleInRad = angle * Mathf.Deg2Rad;
		float cos = Mathf.Cos (angleInRad);
		float sin = Mathf.Sin (angleInRad);
		matrix.m11 = 1;
		matrix.m12 = 0;
		matrix.m13 = 0;
		matrix.m21 = 0;
		matrix.m22 = cos;
		matrix.m23 = -sin;
		matrix.m31 = 0;
		matrix.m32 = sin;
		matrix.m33 = cos;

		return matrix;
	}
	public Matrix3x3 SetYRotation (float angle)
	{
		var matrix = new Matrix3x3 ();
		float angleInRad = angle * Mathf.Deg2Rad;
		float cos = Mathf.Cos (angleInRad);
		float sin = Mathf.Sin (angleInRad);
		m11 = cos;
		m12 = 0;
		m13 = sin;
		m21 = 0;
		m22 = 1;
		m23 = 0;
		m31 = -sin;
		m32 = 0;
		m33 = cos;

		return matrix;
	}
	public Matrix3x3 SetZRotation (float angle)
	{
		var matrix = new Matrix3x3 ();
		float angleInRad = angle * Mathf.Deg2Rad;
		float cos = Mathf.Cos (angleInRad);
		float sin = Mathf.Sin (angleInRad);
		m11 = cos;
		m12 = -sin;
		m13 = 0;
		m21 = sin;
		m22 = cos;
		m23 = 0;
		m31 = 0;
		m32 = 0;
		m33 = 1;

		return matrix;
	}

	public static Vector3 operator * (Matrix3x3 m, Vector3 v)
	{
		Vector3 result;
		result.x = m.m11 * v.x + m.m12 * v.y + m.m13 * v.z;
		result.y = m.m21 * v.x + m.m22 * v.y + m.m23 * v.z;
		result.z = m.m31 * v.x + m.m32 * v.y + m.m33 * v.z;
		return result;
	}
}