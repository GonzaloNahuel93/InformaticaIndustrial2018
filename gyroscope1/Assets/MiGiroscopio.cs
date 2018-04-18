using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiGiroscopio : MonoBehaviour {

	Gyroscope m_Gyro;
	// Use this for initialization
	void Start()
	{
		//Set up and enable the gyroscope (check your device has one)
		m_Gyro = Input.gyro;
		m_Gyro.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Input.gyro.attitude;
	}
}
