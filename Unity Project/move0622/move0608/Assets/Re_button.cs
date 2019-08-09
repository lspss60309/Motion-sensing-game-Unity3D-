using UnityEngine;
using System.Collections;

public class Re_button : MonoBehaviour {
	public void Restartbtn(){
		if(NewBehaviourScript.abc == 1){
			Application.LoadLevel("01");
		}
		if(NewBehaviourScript.abc == 2){
			Application.LoadLevel("03");
		}
	}
}
