﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HGYXFadeIn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Finish() {
		Globe.loadName = "LoginScene";
		Application.LoadLevel ("LoadingScene");
		
	}
}
