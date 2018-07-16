using UnityEngine;

public class GyroscopeRotation : MonoBehaviour {

	Gyroscope m_Gyro;
	//public Vector3 baseAcceleration;
	
	void Start()
	{
		m_Gyro = Input.gyro;
		m_Gyro.enabled = true;
	}
	
	void Update () {
		Vector3 lect = Input.gyro.attitude.eulerAngles;
		Quaternion q = Quaternion.Euler(
			-lect.y,
			-lect.z, 
			lect.x);//y x z
		transform.rotation = q;
	}
}
