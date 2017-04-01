using UnityEngine;
using System.Collections;

public class sellWheatOne : MonoBehaviour {
	
	gameManager GameManager;

	public GameObject Warnings;
	public GameObject Wheat;
	// Use this for initialization
	void OnMouseUpAsButton(){
		
		GameManager = GameObject.FindObjectOfType<gameManager> ();
		
		if (GameManager.wheat < 1)
		{
			Warnings.SetActive(true);
			Wheat.SetActive(true);
		}
		
		else if (GameManager.wheat >= 1)
		{
			GameManager.money = GameManager.money + 20;
			GameManager.wheat = GameManager.wheat - 1;
		}
	}
}
