using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blink : MonoBehaviour {

	Color _orig;
	Material _mat;
	public Color start;
	public Color end;
	public float rate = 5;
	public Color lerpedColor;

	// Use this for initialization
	void Start () {
		Renderer[] renderers = GetComponentsInChildren<Renderer> ();
		Material m = renderers [0].material;
		_orig = m.color;
		_mat = m;
			
	}
	
	// Update is called once per frame
	void Update () {
			lerpedColor = Color.Lerp (end, start, Mathf.PingPong (rate * Time.time, 1));
			_mat.color = lerpedColor;

	}

}