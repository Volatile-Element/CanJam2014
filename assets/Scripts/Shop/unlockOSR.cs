using UnityEngine;
using System.Collections;

public class unlockOSR : MonoBehaviour {

	gameManager GameManager;

	public GameObject Warnings;
	public GameObject OSR;
	// Use this for initialization
	void OnMouseUpAsButton(){
		
		GameManager = GameObject.FindObjectOfType<gameManager> ();
		
		if (GameManager.money < 750)
		{
			Warnings.SetActive(true);
			OSR.SetActive(true);
		}
		
		else if (GameManager.money >= 750)
		{
			GameManager.money = GameManager.money - 750;
			GameManager.osrUnlocked = true;
		}
	}
}
