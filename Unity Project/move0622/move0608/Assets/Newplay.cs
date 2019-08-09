using UnityEngine;
using System.Collections;

public class Newplay : MonoBehaviour {
	bool flag;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(this);//這個作用是場景切換時，一下代碼不撤銷
		flag=true;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			if(flag){
				flag=false;
			}
			else{
				flag=true;
			}
		}
	
	}
	void OnGUI(){
		//if(!flag){
		//	return;
		//}
		if(GUI.Button(new Rect(Screen.width/2-50,Screen.height/2-30,40,60),"Play")){
			Application.LoadLevel(01);
		}
	}
}
