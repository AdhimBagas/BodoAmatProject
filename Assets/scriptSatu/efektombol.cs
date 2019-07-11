using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class efektombol : MonoBehaviour {
float scaleX,scaleY;
	// Use this for initialization
	void Start () {
		scaleX = transform.localScale.x;
		scaleY = transform.localScale.y;
	}
	void OnMouseDown(){
		transform.localScale = new Vector2 (scaleX*1.2f, scaleY/1.2f);

	}

	void OnMouseUp(){
		transform.localScale = new Vector2 (scaleX, scaleY);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
