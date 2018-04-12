using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcceleratorRotation : MonoBehaviour
{

	private float Speed = 20f;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(Input.acceleration.y, Input.acceleration.x, 0) * Time.deltaTime * Speed);
	}
}
