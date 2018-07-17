using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour {
	
	public Transform _ControlPoint;
	public Text _Text;
	public float _Distance;
	
	// Update is called once per frame
	void Update ()
	{
		_Text.text = "Distancia a la esfera: "+ _Distance.ToString("0.00") + " Metros";
		_Distance = Vector3.Distance(_ControlPoint.position, transform.position);
	}
}
