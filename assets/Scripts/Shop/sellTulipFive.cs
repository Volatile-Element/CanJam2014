using UnityEngine;
using System.Collections;

public class sellTulipFive : MonoBehaviour {
	
	gameManager GameManager;

	public GameObject Warnings;
	public GameObject Tulip;
	// Use this for initialization
	void OnMouseUpAsButton(){
		
		GameManager = GameObject.FindObjectOfType<gameManager> ();
		
		if (GameManager.tulip < 5)
		{
			Warnings.SetActive(true);
			Tulip.SetActive(true);
		}
		
		else if (GameManager.tulip >= 5)
		{
			GameManager.money = GameManager.money + 150;
			GameManager.tulip = GameManager.tulip - 5;
		}
	}
}
