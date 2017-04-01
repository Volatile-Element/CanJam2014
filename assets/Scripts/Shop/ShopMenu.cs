using UnityEngine;
using System.Collections;

public class ShopMenu : MonoBehaviour {
	public GameObject Shop;
	// Use this for initialization
	void Start () {
		Shop.SetActive (false);
		Time.timeScale = 1;
	}

}
