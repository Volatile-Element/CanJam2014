using UnityEngine;
using System.Collections;

public class shopSeeds : MonoBehaviour {
	gameManager GameManager;
	public TextMesh Seeds;
	// Use this for initialization
	void Start () {
		GameManager = GameObject.FindObjectOfType<gameManager> ();
		Seeds.text = "Seeds:    " + GameManager.seeds;
	}
	
	// Update is called once per frame
	void Update () {
		Seeds.text = "Seeds:    " + GameManager.seeds;
	}
}
