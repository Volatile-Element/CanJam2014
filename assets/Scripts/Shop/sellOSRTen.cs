using UnityEngine;
using System.Collections;

public class sellOSRTen : MonoBehaviour {
	
	gameManager GameManager;

	public GameObject Warnings;
	public GameObject OSR;
	// Use this for initialization
	void OnMouseUpAsButton(){
		
		GameManager = GameObject.FindObjectOfType<gameManager> ();
		
		if (GameManager.osr < 10)
		{
			Warnings.SetActive(true);
			OSR.SetActive(true);
		}
		
		else if (GameManager.osr >= 10)
		{
			GameManager.money = GameManager.money + 400;
			GameManager.osr = GameManager.osr - 10;
		}
	}
}
