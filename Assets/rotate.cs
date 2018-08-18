using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {

	public float rate = 10;

	// Use this for initialization
	void Start () {
		Debug.Log ("position = " + transform.position);
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.AngleAxis((Time.realtimeSinceStartup * rate), Vector3.up);
		
	}
}
