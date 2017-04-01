using UnityEngine;
using System.Collections;

public class ResumeGame : MonoBehaviour {
	public GameObject Pause;

	void OnMouseUpAsButton()
	{
		Pause.SetActive (false);
		Time.timeScale = 1;
	}
}
