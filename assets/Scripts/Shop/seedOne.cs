using UnityEngine;
using System.Collections;

public class seedOne : MonoBehaviour {

	gameManager GameManager;

	public GameObject Warnings;
	public GameObject Fund;
	// Use this for initialization
	void OnMouseUpAsButton(){
	
		GameManager = GameObject.FindObjectOfType<gameManager> ();

		if (GameManager.money < 5)
		{
			Warnings.SetActive(true);
			Fund.SetActive(true);
		}

		else if (GameManager.money >= 5)
		{
			GameManager.money = GameManager.money - 5;
			GameManager.seeds = GameManager.seeds + 1;
		}

	}

}
