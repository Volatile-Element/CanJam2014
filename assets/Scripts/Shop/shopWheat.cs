using UnityEngine;
using System.Collections;

public class shopWheat : MonoBehaviour {
	gameManager GameManager;
	public TextMesh WheatQuantity;
	// Use this for initialization
	void Start () {
		GameManager = GameObject.FindObjectOfType<gameManager> ();
		WheatQuantity.text = "" + GameManager.wheat;
	}
	
	// Update is called once per frame
	void Update () {
		WheatQuantity.text = "" + GameManager.wheat;
	}
}
