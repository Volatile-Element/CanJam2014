using UnityEngine;
using System.Collections;

public class sellLinseedFive : MonoBehaviour {
	
	gameManager GameManager;

	public GameObject Warnings;
	public GameObject Linseed;
	// Use this for initialization
	void OnMouseUpAsButton(){
		
		GameManager = GameObject.FindObjectOfType<gameManager> ();
		
		if (GameManager.linseed < 5)
		{
			Warnings.SetActive(true);
			Linseed.SetActive(true);
		}
		
		else if (GameManager.linseed >= 5)
		{
			GameManager.money = GameManager.money + 250;
			GameManager.linseed = GameManager.linseed - 5;
		}
	}
}
