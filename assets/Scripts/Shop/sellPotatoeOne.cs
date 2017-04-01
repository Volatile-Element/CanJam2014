using UnityEngine;
using System.Collections;

public class sellPotatoeOne : MonoBehaviour {

	gameManager GameManager;

	public GameObject Warnings;
	public GameObject Potato;
	// Use this for initialization
	void OnMouseUpAsButton(){

		GameManager = GameObject.FindObjectOfType<gameManager> ();
		
		if (GameManager.potatoes < 1)
		{
			Warnings.SetActive(true);
			Potato.SetActive(true);
		}
		
		else if (GameManager.potatoes >= 1)
		{
			GameManager.money = GameManager.money + 10;
			GameManager.potatoes = GameManager.potatoes - 1;
		}
	}
}
