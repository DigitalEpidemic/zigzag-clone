﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

	public static UIManager instance;

	public GameObject zigZagPanel;
	public GameObject gameOverPanel;
	public GameObject tapText;
	public Text score;
	public Text highScore1;
	public Text highScore2;

	void Awake () {
		if (instance == null) {
			instance = this;
		}
	}

	// Use this for initialization
	void Start () {
		highScore1.text = "High Score: " + PlayerPrefs.GetInt ("highScore");
	}

	public void GameStart () {
		tapText.SetActive (false);
		zigZagPanel.GetComponent<Animator> ().Play ("PanelUp");
	}

	public void GameOver () {
		score.text = PlayerPrefs.GetInt ("score").ToString();
		highScore2.text = PlayerPrefs.GetInt ("highScore").ToString();
		gameOverPanel.SetActive (true);
	}

	public void Reset () {
		SceneManager.LoadScene (0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
