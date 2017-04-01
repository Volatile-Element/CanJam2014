using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class grassTile : MonoBehaviour {

	public int spriteType = 1;
	public List<Sprite> list = new List<Sprite>();

	// Use this for initialization
	void Start () {
		changeSprite ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void changeSprite()
	{
		switch (spriteType) {
		case 1:
			gameObject.GetComponent<SpriteRenderer>().sprite = list[0];
			break;
		case 2:
			gameObject.GetComponent<SpriteRenderer>().sprite = list[1];
			break;
		case 3:
			gameObject.GetComponent<SpriteRenderer>().sprite = list[2];
			gameObject.transform.parent.GetComponent<BoxCollider>().isTrigger = false;
			break;
		case 4:
			gameObject.GetComponent<SpriteRenderer>().sprite = list[3];
			gameObject.transform.parent.GetComponent<BoxCollider>().isTrigger = false;
			break;
				}
	}
}
