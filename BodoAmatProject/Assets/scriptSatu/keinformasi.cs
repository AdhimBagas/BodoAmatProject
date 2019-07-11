using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keinformasi: MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	void OnMouseDown(){
		 SceneManager.LoadScene("informasi", LoadSceneMode.Single);
		//Application.LoadLevel ("penting");
	}

	void OnMouseUp (){

	}
	// Update is called once per frame
	void Update () {
		
	}
}
