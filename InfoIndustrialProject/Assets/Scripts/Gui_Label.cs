using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gui_Label : MonoBehaviour {

	// Use this for initialization
	private void OnGUI () {
	
		GUI.Label (new Rect (200, 100, 100, 100), "hola");
	}


}
