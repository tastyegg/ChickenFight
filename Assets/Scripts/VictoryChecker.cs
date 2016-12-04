﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class VictoryChecker : MonoBehaviour {
	public RoundTracker rt1, rt2;
	Text txt;

	void Start ()
	{
		txt = GetComponent<Text>();
		txt.enabled = false;
	}

	// Update is called once per frame
	void Update () {
		if (rt1.FinishedGame())
		{
			txt.enabled = true;
			txt.text = "Marie Wins!\nPress 'Fire' to Restart";
			//Reset On Input
			if (Input.GetAxis("Fire1") > 0 || Input.GetAxis("Fire2") > 0)
			{
				RepeatGame();
			}
		}
		else if (rt2.FinishedGame())
		{
			txt.enabled = true;
			txt.text = "Suede Wins!\nPress 'Fire' to Restart";
			//Reset On Input
			if (Input.GetAxis("Fire1") > 0 || Input.GetAxis("Fire2") > 0)
			{
				RepeatGame();
			}
		}
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			SceneManager.LoadScene(0);
		}
	}

	void RepeatGame()
	{
		SceneManager.LoadScene(1);
		/* // Too much of a hassle
		txt.text = "";
		rt1.RepeatGame();
		rt2.RepeatGame();
		*/
	}
}
