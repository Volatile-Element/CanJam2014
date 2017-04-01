using UnityEngine;
using System.Collections;

public class sellPotatoeTen : MonoBehaviour {
	
	gameManager GameManager;

	public GameObject Warnings;
	public GameObject Potato;
	// Use this for initialization
	void OnMouseUpAsButton(){
		
		GameManager = GameObject.FindObjectOfType<gameManager> ();
		
		if (GameManager.potatoes < 10)
		{
			Warnings.SetActive(true);
			Potato.SetActive(true);
		}
		
		else if (GameManager.potatoes >= 10)
		{
			GameManager.money = GameManager.money + 100;
			GameManager.potatoes = GameManager.potatoes - 10;
		}
	}
}
