﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingScript : MonoBehaviour
{
    public Transform LoadingBar;

	[SerializeField] private float currentAmount;
	[SerializeField] private float speed;

	// Update is called once per frame
	void Update () {
		if (currentAmount < 100) {
			currentAmount += speed * Time.deltaTime;
			Debug.Log ((int)currentAmount);
		} else {
			Application.LoadLevel ("Main_Menu");
		}

		LoadingBar.GetComponent<Image> ().fillAmount = currentAmount / 100;
	}

}
