﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PauseMenue : MonoBehaviour {

	private bool GameisPaused =false;
	public Canvas Menuecanvas;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ShowPauseMenue ();


	if (Input.GetKeyDown(KeyCode.P) && !GameisPaused) {
			GameisPaused = true;
			Debug.Log("GameisPaused");
		} else if (Input.GetKeyDown(KeyCode.P) && GameisPaused){
			GameisPaused = false;
			Debug.Log("GameResumed");
		}
	}

	public void ShowPauseMenue(){
		if (GameisPaused) {
			GameManager.instance.UserPlayers[GameManager.instance.currentPlayerIndex].attacking=false;
			GameManager.instance.UserPlayers[GameManager.instance.currentPlayerIndex].aiming=false;
			GameManager.instance.UserPlayers[GameManager.instance.currentPlayerIndex].moving=false;

			GameManager.instance.removeTileHighlights ();

			Time.timeScale=0;
			Menuecanvas.enabled = true;
			Hotkey.hotk.enabled = false;



		} else {
			Time.timeScale=1;
			Menuecanvas.enabled = false;
			Hotkey.hotk.enabled = true;
		}
	}

	public void ResumeGame(){
		GameisPaused = false;
		Debug.Log("GameResumed");
	}

	public void BacktoMenue(){
		Application.LoadLevel (0);
	}
	

}
