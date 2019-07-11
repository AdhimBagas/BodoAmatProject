using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class petunjuktombol : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	void OnMouseDown(){
		SceneManager.LoadScene("petunjuk", LoadSceneMode.Single);
	}

	void OnMouseUp (){

	}
	// Update is called once per frame
	void Update () {
		
	}
}
