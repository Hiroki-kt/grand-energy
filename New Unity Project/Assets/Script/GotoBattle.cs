﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoBattle : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SceneManager.LoadScene("MenuScene", LoadSceneMode.Additive);
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void QuestMenuClick(){

        SceneManager.LoadScene("GameScene");
    }
}
