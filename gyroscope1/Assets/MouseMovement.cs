
using UnityEngine;

public class MouseMovement : MonoBehaviour {

	float rotSpeed = 20;

	// Update is called once per frame
	void Update () {
		float rotX = 1.0f;
		float rotY = Input.GetAxis("Mouse Y")*rotSpeed*Mathf.Deg2Rad;

		transform.RotateAround(Vector3.up, -rotX);
		transform.RotateAround(Vector3.right, rotY);
	}

}
