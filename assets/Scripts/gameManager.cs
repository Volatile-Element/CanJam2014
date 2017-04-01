using UnityEngine;
using System.Collections;

public class gameManager : MonoBehaviour {

	public gameManager gm;
	public int farmCount;
	public int potatoes, wheat, tulip, osr, linseed;
	public int money, fuel, seeds, fertalizer;
	public int selPlant;
	private float cumTime;
		
	public bool wheatUnlocked = false, tulipUnlocked = false, osrUnlocked = false, linseedUnlocked = false;

	// Use this for initialization
	void Start () {
		gm = GameObject.FindObjectOfType<gameManager> ().GetComponent<gameManager>();
		selPlant = 2;
		money = 10000;
		seeds = 10;
		farmCount = 1;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (farmCount);
		cumTime = cumTime + Time.deltaTime;
		if (cumTime > 5) {
			money -= (100*farmCount);
			cumTime = 0;
				}
		//Debug.Log (potatoes);
		//Debug.Log (wheat);
		//Debug.Log (tulip);
		//Debug.Log (osr);
		//Debug.Log (linseed);

	}
}
