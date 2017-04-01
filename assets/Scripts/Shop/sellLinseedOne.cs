using UnityEngine;
using System.Collections;

public class sellLinseedOne : MonoBehaviour {
	
	gameManager GameManager;

	public GameObject Warnings;
	public GameObject Linseed;
	// Use this for initialization
	void OnMouseUpAsButton(){
		
		GameManager = GameObject.FindObjectOfType<gameManager> ();
		
		if (GameManager.linseed < 1)
		{
			Warnings.SetActive(true);
			Linseed.SetActive(true);
		}
		
		else if (GameManager.linseed >= 1)
		{
			GameManager.money = GameManager.money + 50;
			GameManager.linseed = GameManager.linseed - 1;
		}
	}
}
