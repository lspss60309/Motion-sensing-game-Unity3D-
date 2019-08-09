using UnityEngine;
using System.Collections;

public class Next : MonoBehaviour {

       void OnTriggerEnter(Collider Bip001) //aaa為自定義碰撞事件
	   {    
		 if (Bip001 .gameObject.name == "player") //如果aaa碰撞事件的物件名稱是CubeA
		 {    
			Application.LoadLevel("03");
		 }
	   }
}

