using UnityEngine;
using System.Collections;

public class sellTulipOne : MonoBehaviour {
	
	gameManager GameManager;

	public GameObject Warnings;
	public GameObject Tulip;
	// Use this for initialization
	void OnMouseUpAsButton(){
		
		GameManager = GameObject.FindObjectOfType<gameManager> ();
		
		if (GameManager.tulip < 1)
		{
			Warnings.SetActive(true);
			Tulip.SetActive(true);
		}
		
		else if (GameManager.tulip >= 1)
		{
			GameManager.money = GameManager.money + 30;
			GameManager.tulip = GameManager.tulip - 1;
		}
	}
}
