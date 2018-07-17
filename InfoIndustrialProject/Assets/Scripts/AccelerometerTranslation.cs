using UnityEngine;

public class AccelerometerTranslation : MonoBehaviour {

	Vector3 startPoint;
	string meterLabel;
	float ajuste = 0.4f;
	float meters;

	void Start(){
		startPoint = transform.position;
	}

	void OnGUI () {
		GUIStyle style = new GUIStyle ();
		style.richText = true;
		GUI.Label (new Rect (80, 80, 200, 100), "<size=30>Distancia: " + meterLabel + "</size>", style);
	}

	void Update () {
		float metersX = transform.position.x - startPoint.x;
		float metersY = transform.position.y - startPoint.y;
		float metersZ = transform.position.z - startPoint.z;
		meters = Mathf.Abs (metersX) + Mathf.Abs (metersY) + Mathf.Abs (metersZ);
		meterLabel = meters.ToString("C");
		transform.Translate(Input.acceleration.x * ajuste, Input.acceleration.y * 0, -Input.acceleration.z * ajuste, Space.World);
	}
}