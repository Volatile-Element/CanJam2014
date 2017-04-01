using UnityEngine;
using System.Collections;

public class sellPotatoeFive : MonoBehaviour {

	gameManager GameManager;

	public GameObject Warnings;
	public GameObject Potato;
	// Use this for initialization
	void OnMouseUpAsButton(){
		
		GameManager = GameObject.FindObjectOfType<gameManager> ();
		
		if (GameManager.potatoes < 5)
		{
			Warnings.SetActive(true);
			Potato.SetActive(true);
		}
		
		else if (GameManager.potatoes >= 5)
		{
			GameManager.money = GameManager.money + 50;
			GameManager.potatoes = GameManager.potatoes - 5;
		}
	}
}
