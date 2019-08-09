using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class levels : MonoBehaviour {
	public Text scoreboard;
	int lv = 0;
	public void Lvbtn() {
		lv = 1;
	}

	void OnGUI(){
	aaaaa:
		if (lv == 1) {
			if (GUI.Button (new Rect (Screen.width / 2 - 0, Screen.height - 70, 70, 30), "Level 01")) {
				Application.LoadLevel ("01");		
			}
			if (GUI.Button (new Rect (Screen.width / 2 - 0, Screen.height - 40, 70, 30), "Level 02")) {
				if(NewBehaviourScript.aaa == 2){
					Application.LoadLevel ("03");
				}else{
					scoreboard.text = "第一關還沒過!";
				}
			}
			if (GUI.Button (new Rect (Screen.width / 2 - 0, Screen.height - 100, 70, 30), "Exit")) {
				lv = 0;
				goto aaaaa;
			}
		}
	}
}


