using UnityEngine;
using System.Collections;

public class Newplay1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI(){
		if(GUI.Button(new Rect(Screen.width/2-50,Screen.height/2-30,40,60),"Play")){
			Application.LoadLevel(01);
		}
	}
}
