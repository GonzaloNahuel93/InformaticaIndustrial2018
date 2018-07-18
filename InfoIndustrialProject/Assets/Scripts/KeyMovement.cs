using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMovement : MonoBehaviour {

	public float translationSpeed = 5.0f;

	void Update () {

		//MOVIMIENTOS EN 2D
		//Movimiento para arriba - VECTOR (0, 1, 0)
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (Vector3.up * Time.deltaTime * translationSpeed, Space.Self);
		}

		//Movimiento para abajo - VECTOR (0, -1, 0)
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (Vector3.down * Time.deltaTime * translationSpeed, Space.Self);
		}

		//Movimiento para la izquierda - VECTOR (-1, 0, 0)
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (Vector3.left * Time.deltaTime * translationSpeed, Space.Self);
		}
		

		//Movimiento para la derecha - VECTOR (1, 0, 0)
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (Vector3.right * Time.deltaTime * translationSpeed, Space.Self);
		}


		//MOVIMIENTOS EN PROFUNDIDAD (3D)
		//Movimiento para el frente - VECTOR (0, 0, 1)
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector3.forward * Time.deltaTime * translationSpeed, Space.Self);
		}

		//Movimiento para atrás - VECTOR (0, 0, -1)
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (Vector3.back * Time.deltaTime * translationSpeed, Space.Self);
		}

	}

}