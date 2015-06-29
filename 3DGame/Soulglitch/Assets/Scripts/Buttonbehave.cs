using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Buttonbehave : MonoBehaviour {

	public Button Attack,Aim,Move;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Buttoninteraction ();
	}

	/// <summary>
	/// Sets Buttens as enabled or disabled at certian conditions.
	/// </summary>
	public void Buttoninteraction(){

		if (GameManager.instance.UserPlayers[GameManager.instance.currentPlayerIndex].ActionPoints<GameManager.instance.UserPlayers[GameManager.instance.currentPlayerIndex].Weapon.APCost){
			Attack.interactable=false;
		}else{Attack.interactable=true;}

		if (GameManager.instance.UserPlayers[GameManager.instance.currentPlayerIndex].ActionPoints<=0){
			Move.interactable=false;
			Aim.interactable=false;
		}else{			
			Move.interactable=true;
			Aim.interactable=true;}

	}


}
