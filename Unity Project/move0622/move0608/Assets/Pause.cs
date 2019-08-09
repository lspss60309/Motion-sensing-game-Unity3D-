using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
	int il = 2;
	void Update () {
		if (Input.GetKeyDown (KeyCode.P)) {
			if (il % 2 == 0) {
				Time.timeScale = 0;
			} else {
				Time.timeScale = 1;
			}
			il = il + 1;
		}
	}
}
