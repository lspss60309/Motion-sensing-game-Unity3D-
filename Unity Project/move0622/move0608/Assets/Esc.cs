using UnityEngine;
using System.Collections;

public class Esc : MonoBehaviour {
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit();
		}
	}
}
