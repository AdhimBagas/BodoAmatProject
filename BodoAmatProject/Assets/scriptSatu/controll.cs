﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controll : MonoBehaviour {
	float x,y;
	public GameObject bankhuruf;
	public int kontrol;
	// Use this for initialization
	void Start () {
		x = transform.localScale.x;
		y = transform.localScale.y;
	}
	void OnMouseDown(){
		transform.localScale = new Vector2 (x*1.2f, y/1.2f);
	}
	
	void OnMouseUp(){
		transform.localScale = new Vector2 (x,y);
		bankhuruf.GetComponent<bank_planet>().control (kontrol);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
