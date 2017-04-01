using UnityEngine;
using System.Collections;

public class sellOSRFive : MonoBehaviour {
	
	gameManager GameManager;

	public GameObject Warnings;
	public GameObject OSR;
	// Use this for initialization
	void OnMouseUpAsButton(){
		
		GameManager = GameObject.FindObjectOfType<gameManager> ();
		
		if (GameManager.osr < 5)
		{
			Warnings.SetActive(true);
			OSR.SetActive(true);
		}
		
		else if (GameManager.osr >= 5)
		{
			GameManager.money = GameManager.money + 200;
			GameManager.osr = GameManager.osr - 5;
		}
	}
}
