﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlpuzzle : MonoBehaviour {
	[SerializeField]
	private Transform[] pictures;

	[SerializeField]
	private GameObject winText;

	public static bool youWin; 

	void Start () 
	{
		winText.SetActive (false);
		youWin = false;
	}

	void update()
	{
		
		if (pictures [0].rotation.z == 0 &&
		    pictures [1].rotation.z == 0 &&
		    pictures [2].rotation.z == 0 &&
		    pictures [3].rotation.z == 0 &&
		    pictures [4].rotation.z == 0 &&
		    pictures [5].rotation.z == 0) 
		{	
			youWin = true;
			winText.SetActive (true);
		}
	}
}
