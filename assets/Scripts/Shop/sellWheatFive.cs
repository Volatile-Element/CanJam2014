using UnityEngine;
using System.Collections;

public class sellWheatFive : MonoBehaviour {
	
	gameManager GameManager;

	public GameObject Warnings;
	public GameObject Wheat;
	// Use this for initialization
	void OnMouseUpAsButton(){
		
		GameManager = GameObject.FindObjectOfType<gameManager> ();
		
		if (GameManager.wheat < 5)
		{
			Warnings.SetActive(true);
			Wheat.SetActive(true);
		}
		
		else if (GameManager.wheat >= 5)
		{
			GameManager.money = GameManager.money + 100;
			GameManager.wheat = GameManager.wheat - 5;
		}
	}
}
