﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour {
	[SerializeField]
	private float time = 60;

	// Use this for initialization
	void Start () {
		//初期値60を表示
		GetComponent<Text>().text = ((int)time).ToString();
	}
	
	// Update is called once per frame
	void Update () {
		//1秒に1ずつ減らす
		time -= Time.deltaTime;
		//マイナスは表示しない
		if(time < 0) time = 0;
		GetComponent<Text> ().text = ((int)time).ToString ();
		
	}
}
