using UnityEngine;
using System.Collections;

public class Rotater2 : MonoBehaviour {

	void Update () 
	{
		transform.Rotate (new Vector3 (30, 0, 30) * Time.deltaTime);
	}
}