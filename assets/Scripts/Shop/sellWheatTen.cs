using UnityEngine;
using System.Collections;

public class sellWheatTen : MonoBehaviour {
	
	gameManager GameManager;

	public GameObject Warnings;
	public GameObject Wheat;
	// Use this for initialization
	void OnMouseUpAsButton(){
		
		GameManager = GameObject.FindObjectOfType<gameManager> ();
		
		if (GameManager.wheat < 10)
		{
			Warnings.SetActive(true);
			Wheat.SetActive(true);
		}
		
		else if (GameManager.wheat >= 10)
		{
			GameManager.money = GameManager.money + 200;
			GameManager.wheat = GameManager.wheat - 10;
		}
	}
}
