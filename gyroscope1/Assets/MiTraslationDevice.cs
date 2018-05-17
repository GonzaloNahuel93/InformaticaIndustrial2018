using System;
using UnityEngine;

public class MiTraslationDevice : MonoBehaviour
{
	[SerializeField] private float Speed = 2f;
	public Vector3 baseAcceleration;
	void Start()
	{
	//transform.rotation.x = 180f;
		//transform.rotation.y = 0f;
		//transform.rotation.z = 90f;
		float x = 0, y = 0, z = 0;
		x += Time.deltaTime * 180;
		y += Time.deltaTime * 0;
		z += Time.deltaTime * 90;
		//transform.rotation = Quaternion.Euler(x,y,z);

		// multiply rotation by 180 on y axis
		//transform.rotation *= Quaternion.Euler(180f,0f,180f);
		//var yy = Input.gyro.attitude.eulerAngles.y;
		baseAcceleration.Set(0f, -180f, 270f);
		//transform.Translate (baseAcceleration);
	}
	// Update is called once per frame
	void Update () {
		Vector3 dir = Vector3.zero;
		dir.x = Math.Abs(Input.acceleration.x) > 0.001 ? -Input.acceleration.y : 0;
		dir.y = Math.Abs(Input.acceleration.y) > 0.001 ? -Input.acceleration.x : 0;
		if (dir.sqrMagnitude > 1)
		{
			dir.Normalize();
		}

		dir *= Time.deltaTime;
		transform.Translate(dir * Speed);
	}
}
