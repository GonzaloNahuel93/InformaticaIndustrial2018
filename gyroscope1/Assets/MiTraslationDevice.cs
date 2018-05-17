using System;
using UnityEngine;

public class MiTraslationDevice : MonoBehaviour
{
	[SerializeField] private float Speed = 2f;

	
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
