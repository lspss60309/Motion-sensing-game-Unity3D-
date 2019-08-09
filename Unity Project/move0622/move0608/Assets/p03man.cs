using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class p03man : MonoBehaviour
{
	GUIText score1 ;
	public static int score_a;
	public Text scoreboard1;


	void Start () { 
		score1 = GameObject.Find("scoreboard1").GetComponent<GUIText>();
		scoreboard1 = GetComponent<Text> ();
	}
	void Update (){

		scoreboard1.text = "分數:" + score_a;
	}
	void OnTriggerEnter(Collider Bip001){
		
		
		if (Bip001 .gameObject.name == "Pick Up") 
		{    
			Destroy(Bip001.gameObject);
			score_a += 10;
			print(score_a);
			scoreboard1.text = "分數:" + score_a;
		}
		if (Bip001 .gameObject.name == "plane00") //如果aaa碰撞事件的物件名稱是CubeA
		{    
			Application.LoadLevel("02");
		}
	}
	
}
