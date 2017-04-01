using UnityEngine;
using System.Collections;

public class sellLinseedTen : MonoBehaviour {
	
	gameManager GameManager;

	public GameObject Warnings;
	public GameObject Linseed;
	// Use this for initialization
	void OnMouseUpAsButton(){
		
		GameManager = GameObject.FindObjectOfType<gameManager> ();
		
		if (GameManager.linseed < 10)
		{
			Warnings.SetActive(true);
			Linseed.SetActive(true);
		}
		
		else if (GameManager.linseed >= 10)
		{
			GameManager.money = GameManager.money + 500;
			GameManager.linseed = GameManager.linseed - 10;
		}
	}
}
