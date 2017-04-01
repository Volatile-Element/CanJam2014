using UnityEngine;
using System.Collections;

public class unlockTulip : MonoBehaviour {

	gameManager GameManager;

	public GameObject Warnings;
	public GameObject Tulip;
	// Use this for initialization
	void OnMouseUpAsButton(){
		
		GameManager = GameObject.FindObjectOfType<gameManager> ();
		
		if (GameManager.money < 500)
		{
			Warnings.SetActive(true);
			Tulip.SetActive(true);
		}
		
		else if (GameManager.money >= 500)
		{
			GameManager.money = GameManager.money - 500;
			GameManager.tulipUnlocked = true;
		}
	
	}
}
