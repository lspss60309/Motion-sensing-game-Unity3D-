using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
	GUIText score ;
	public static int abc = 1;
	public static int aaa = 1;
	public int score1 = 0;
	public Text scoreboard;
	void Start () { 

	}


	void OnTriggerEnter(Collider Bip001){
	
		if (Bip001.gameObject.name == "Pick Up") {    
			Destroy (Bip001.gameObject);
		}

		if (Bip001 .gameObject.name == "plane00") //如果aaa碰撞事件的物件名稱是CubeA
		{    
			Application.LoadLevel("02");
		}
		if (Bip001 .gameObject.name == "next") //如果aaa碰撞事件的物件名稱是CubeA
		{    
			abc = 2;
			aaa = 2;
			Application.LoadLevel("03");
		}
	}


}