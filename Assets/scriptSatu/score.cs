﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("skor", 0);
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text> ().text = PlayerPrefs.GetInt ("skor").ToString();
	}
}
