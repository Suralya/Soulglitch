﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Characterbuttons : MonoBehaviour {

	public Text CharOne,CharTwo,CharThree,CharFour,WeaponOne,WeaponTwo,WeaponThree,WeaponFour;
	public Button CharacterButtonOne,CharacterButtonTwo,CharacterButtonThree,CharacterButtonFour;


	// Use this for initialization
	void Start () {
		SetCharacterNames ();
	    
	}
	
	// Update is called once per frame
	void Update () {
		DisableDeadChar ();
        SetWeaponNames();
	}

	/// <summary>
	/// Sets the character names inside assigned buttons.
	/// </summary>
	void SetCharacterNames(){
		CharOne.text = GameManager.instance.UserPlayers[0].playerName;
		CharTwo.text = GameManager.instance.UserPlayers[1].playerName;
		CharThree.text = GameManager.instance.UserPlayers[2].playerName;
		CharFour.text = GameManager.instance.UserPlayers[3].playerName;
	}


    void SetWeaponNames()
    {
        WeaponOne.text = GameManager.instance.UserPlayers[0].Weapon.Weaponname;
        WeaponTwo.text = GameManager.instance.UserPlayers[1].Weapon.Weaponname;
        WeaponThree.text = GameManager.instance.UserPlayers[2].Weapon.Weaponname;
        WeaponFour.text = GameManager.instance.UserPlayers[3].Weapon.Weaponname;
    }

	/// <summary>
	/// Disables dead Userchar.
	/// </summary>
	void DisableDeadChar(){
		if (GameManager.instance.UserPlayers [0].HP<=0) {CharacterButtonOne.interactable = false;}
		if (GameManager.instance.UserPlayers [1].HP<=0) {CharacterButtonTwo.interactable = false;}
		if (GameManager.instance.UserPlayers [2].HP<=0) {CharacterButtonThree.interactable = false;}
		if (GameManager.instance.UserPlayers [3].HP<=0) {CharacterButtonFour.interactable = false;}
	}

	void HighlightSelected(){
		//--- Hilight selected character
	}

}
