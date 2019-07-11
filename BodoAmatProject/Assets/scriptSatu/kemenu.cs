using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class kemenu:MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	void OnMouseDown(){
		SceneManager.LoadScene("menu", LoadSceneMode.Single);
	}

	void OnMouseUp (){

	}
	// Update is called once per frame
	void Update () {
		
	}
}
