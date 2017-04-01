using UnityEngine;
using System.Collections;

public class quit : MonoBehaviour {
	
	public Light spot;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnMouseEnter()
	{
		spot.intensity = 2.1f;
	}
	void OnMouseExit()
	{
		spot.intensity = 1.0f;
	}
	void OnMouseDown()
	{
		Application.Quit();
	}
}
