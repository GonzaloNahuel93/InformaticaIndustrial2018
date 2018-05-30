using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiGiroscopio : MonoBehaviour {

	Gyroscope m_Gyro;
	// Use this for initialization
	public Vector3 baseAcceleration;
	void Start()
	{
		//Set up and enable the gyroscope (check your device has one)
		m_Gyro = Input.gyro;
		m_Gyro.enabled = true;
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
		baseAcceleration.Set(0f, -180f, 270f); // = Input.gyro.attitude.eulerAngles;//userAcceleration;
		//baseAcceleration = Input.gyro.attitude.eulerAngles;//userAcceleration;
		//Input.gyro.attitude.eulerAngles = baseAcceleration;
	}
	
	// Update is called once per frame
	void Update () {
		//transform.rotation = Input.gyro.attitude;
		//float xi = Input.gyro.attitude.x ;//- baseAcceleration.x;
		//float yi = Input.gyro.attitude.y ;//- baseAcceleration.y;
		//float zi = Input.gyro.attitude.z ;//- baseAcceleration.z;

		Vector3 lect = Input.gyro.attitude.eulerAngles;
		Quaternion q = Quaternion.Euler((lect.x - baseAcceleration.x),-(lect.y - baseAcceleration.y), -(lect.z - baseAcceleration.z));
		//transform.rotation = Input.gyro.attitude;  //q;
		transform.rotation = q;
	}
}
