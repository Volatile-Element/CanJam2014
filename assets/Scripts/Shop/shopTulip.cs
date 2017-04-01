using UnityEngine;
using System.Collections;

public class shopTulip : MonoBehaviour {
	gameManager GameManager;
	public TextMesh TulipQuantity;
	// Use this for initialization
	void Start () {
		GameManager = GameObject.FindObjectOfType<gameManager> ();
		TulipQuantity.text = "" + GameManager.tulip;
	}
	
	// Update is called once per frame
	void Update () {
		TulipQuantity.text = "" + GameManager.tulip;
	}
}
