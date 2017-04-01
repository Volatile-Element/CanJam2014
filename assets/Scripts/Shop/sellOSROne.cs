using UnityEngine;
using System.Collections;

public class sellOSROne : MonoBehaviour {
	
	gameManager GameManager;

	public GameObject Warnings;
	public GameObject OSR;
	// Use this for initialization
	void OnMouseUpAsButton(){
		
		GameManager = GameObject.FindObjectOfType<gameManager> ();
		
		if (GameManager.osr < 1)
		{
			Warnings.SetActive(true);
			OSR.SetActive(true);
		}
		
		else if (GameManager.osr >= 1)
		{
			GameManager.money = GameManager.money + 40;
			GameManager.osr = GameManager.osr - 1;
		}
	}
}
