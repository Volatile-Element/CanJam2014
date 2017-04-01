using UnityEngine;
using System.Collections;

public class endgametimer : MonoBehaviour {

	float cumTime;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		cumTime += Time.deltaTime;
		if (cumTime > 5)
						Application.LoadLevel (0);
	}
}
