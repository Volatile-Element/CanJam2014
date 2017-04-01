using UnityEngine;
using System.Collections;

public class shopLinseed : MonoBehaviour {
	gameManager GameManager;
	public TextMesh LinseedQuantity;
	// Use this for initialization
	void Start () {
		GameManager = GameObject.FindObjectOfType<gameManager> ();
		LinseedQuantity.text = "" + GameManager.linseed;
	}
	
	// Update is called once per frame
	void Update () {
		LinseedQuantity.text = "" + GameManager.linseed;
	}
}
