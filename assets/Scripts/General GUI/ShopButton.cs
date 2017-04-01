using UnityEngine;
using System.Collections;

public class ShopButton : MonoBehaviour {
	public GameObject Shop;
	void OnMouseUpAsButton()
	{
		Time.timeScale = 0;
		Shop.SetActive (true);
	}
}
