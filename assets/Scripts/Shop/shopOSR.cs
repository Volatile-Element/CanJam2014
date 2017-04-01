using UnityEngine;
using System.Collections;

public class shopOSR : MonoBehaviour {
	gameManager GameManager;
	public TextMesh OSRQuantity;
	// Use this for initialization
	void Start () {
		GameManager = GameObject.FindObjectOfType<gameManager> ();
		OSRQuantity.text = "" + GameManager.osr;
	}
	
	// Update is called once per frame
	void Update () {
		OSRQuantity.text = "" + GameManager.osr;
	}
}
