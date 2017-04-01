using UnityEngine;
using System.Collections;

public class close : MonoBehaviour {
	public GameObject Shop;
	
	void OnMouseUpAsButton()
	{
		Shop.SetActive (false);
		Time.timeScale = 1;
	}
}
