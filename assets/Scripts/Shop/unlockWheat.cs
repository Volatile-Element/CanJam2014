using UnityEngine;
using System.Collections;

public class unlockWheat : MonoBehaviour {

	gameManager GameManager;

	public GameObject Warnings;
	public GameObject Wheat;
	// Use this for initialization
	void OnMouseUpAsButton(){

		GameManager = GameObject.FindObjectOfType<gameManager> ();

		if (GameManager.money < 250)
		{
			Warnings.SetActive(true);
			Wheat.SetActive(true);
		}
		
		else if (GameManager.money >= 250)
		{
			GameManager.money = GameManager.money - 250;
			GameManager.wheatUnlocked = true;
		}
	
	}
}
