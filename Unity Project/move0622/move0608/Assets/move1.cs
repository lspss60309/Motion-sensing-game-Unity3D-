using UnityEngine;
using System.Collections;

public class move1 : MonoBehaviour {
	
	public Vector3 V3_random;
	public float f_Time=1;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//gameObject.transform.position+=new Vector3 (0, 4, 0);//將位子坐蕾家的動作(往X軸)
		gameObject.transform.position = new Vector3 (Mathf.PingPong(Time.time,5f)-2,2,5);
		
	}
}
