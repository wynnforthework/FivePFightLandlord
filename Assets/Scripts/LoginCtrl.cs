using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginCtrl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Login() {
		Globe.loadName = "GameHallScene";
		Application.LoadLevel ("LoadingScene");
	}
}
