using UnityEngine;
using System.Collections;

public class seedSix : MonoBehaviour {

	gameManager GameManager;

	public GameObject Warnings;
	public GameObject Fund;
	// Use this for initialization
	void OnMouseUpAsButton(){
		
		GameManager = GameObject.FindObjectOfType<gameManager> ();
		
		if (GameManager.money < 25)
		{
			Warnings.SetActive(true);
			Fund.SetActive(true);
		}
		
		else if (GameManager.money >= 25)
		{
			GameManager.money = GameManager.money - 25;
			GameManager.seeds = GameManager.seeds + 6;
		}
		
	}
}