using UnityEngine;
using System.Collections;

public class sellTulipTen : MonoBehaviour {
	
	gameManager GameManager;

	public GameObject Warnings;
	public GameObject Tulip;
	// Use this for initialization
	void OnMouseUpAsButton(){
		
		GameManager = GameObject.FindObjectOfType<gameManager> ();
		
		if (GameManager.tulip < 10)
		{
			Warnings.SetActive(true);
			Tulip.SetActive(true);
		}
		
		else if (GameManager.tulip >= 10)
		{
			GameManager.money = GameManager.money + 300;
			GameManager.tulip = GameManager.tulip - 10;
		}
	}
}
