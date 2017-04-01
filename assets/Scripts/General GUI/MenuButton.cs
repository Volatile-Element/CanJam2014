using UnityEngine;
using System.Collections;

public class MenuButton : MonoBehaviour {
	public GameObject Pause;
	// Use this for initialization
	void OnMouseUpAsButton()
	{
		Time.timeScale = 0;
		Pause.SetActive(true);
	}
}
