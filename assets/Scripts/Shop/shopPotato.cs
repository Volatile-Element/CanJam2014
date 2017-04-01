using UnityEngine;
using System.Collections;

public class shopPotato : MonoBehaviour {
	gameManager GameManager;
	public TextMesh PotatoQuantity;
	// Use this for initialization
	void Start () {
		GameManager = GameObject.FindObjectOfType<gameManager> ();
		PotatoQuantity.text = "" + GameManager.potatoes;
	}
	
	// Update is called once per frame
	void Update () {
		PotatoQuantity.text = "" + GameManager.potatoes;
	}
}
