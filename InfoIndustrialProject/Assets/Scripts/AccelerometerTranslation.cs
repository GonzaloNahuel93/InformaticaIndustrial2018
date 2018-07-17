using UnityEngine;

public class AccelerometerTranslation : MonoBehaviour {
	
	private void Update () {	
		transform.Translate(Input.acceleration.x, 0, -Input.acceleration.z,  Space.World);	
	}
}
