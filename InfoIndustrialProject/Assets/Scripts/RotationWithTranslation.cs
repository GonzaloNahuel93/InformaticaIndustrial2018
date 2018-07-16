using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationWithTranslation : MonoBehaviour {

	Vector3 startPoint;
	string meterLabel;

	void Start(){
		startPoint = transform.position;
	}

	void OnGUI () {

		GUI.Label (new Rect (300, 200, 100, 100), "Distancia: " + meterLabel);
	}

	void Update () {
		float meters = transform.position.x - startPoint.x;
	 meterLabel = meters.ToString();
		//GUI.Label (new Rect (300, 200, 100, 100), meterLabel);
		transform.Translate(Input.acceleration.x, 0, -Input.acceleration.z,  Space.World);
	}


}
