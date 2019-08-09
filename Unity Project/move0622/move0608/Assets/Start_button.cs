using UnityEngine;
using System.Collections;

public class Start_button : MonoBehaviour {
	
	public void Startbtn() {
		NewBehaviourScript.abc = 1;
		Application.LoadLevel("01");
	}

}
