using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {
	public GameObject Pause;
	// Use this for initialization
	void Start () {
		Pause.SetActive (false);
		Time.timeScale = 1;
	}
}
