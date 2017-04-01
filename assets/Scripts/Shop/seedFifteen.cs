using UnityEngine;
using System.Collections;

public class seedFifteen : MonoBehaviour {

	gameManager GameManager;
	public GameObject Warnings;
	public GameObject Fund;
	// Use this for initialization
	void OnMouseUpAsButton(){
		
		GameManager = GameObject.FindObjectOfType<gameManager> ();
		
		if (GameManager.money < 50)
		{
			Warnings.SetActive(true);
			Fund.SetActive(true);
		}
		
		else if (GameManager.money >= 50)
		{
			GameManager.money = GameManager.money - 50;
			GameManager.seeds = GameManager.seeds + 15;
		}
		
	}
}