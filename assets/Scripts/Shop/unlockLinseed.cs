using UnityEngine;
using System.Collections;

public class unlockLinseed : MonoBehaviour {

	gameManager GameManager;

	public GameObject Warnings;
	public GameObject Linseed;
	// Use this for initialization
	void OnMouseUpAsButton(){
		
		GameManager = GameObject.FindObjectOfType<gameManager> ();
		
		if (GameManager.money < 1000)
		{
			Warnings.SetActive(true);
			Linseed.SetActive(true);
		}
		
		else if (GameManager.money >= 1000)
		{
			GameManager.money = GameManager.money - 1000;
			GameManager.linseedUnlocked = true;
		}
	}
}
