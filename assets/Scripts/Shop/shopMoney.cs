using UnityEngine;
using System.Collections;

public class shopMoney : MonoBehaviour {
	gameManager GameManager;
	public TextMesh Money;
	// Use this for initialization
	void Start () {
		GameManager = GameObject.FindObjectOfType<gameManager> ();
		Money.text = "Money:    " + GameManager.money;
	}
	
	// Update is called once per frame
	void Update () {
		Money.text = "Money:    " + GameManager.money;
	}
}
