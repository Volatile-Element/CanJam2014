using UnityEngine;
using System.Collections;

public class GuiManager : MonoBehaviour {
	public GameObject GUI;

	//Ashs shit
	GameObject GUIbar;
	gameManager gm;
	int selectPlant;
	int lastSelPlant;
	SpriteRenderer potato, wheat, tulip, osr, linseed;

	// Use this for initialization
	void Start () {
		float targetRatio = 16f / 9f;
		//float currentRatio = (float)Screen.width / (float)Screen.height;
		float currentRatio = (float)Screen.width / (float)Screen.height;
		float scale = currentRatio / targetRatio;
		//float heightUnit = ((Screen.height / 2f) / 100f);
		float heightUnit =(((float)Screen.height/2f)/100f);
		Camera.main.orthographicSize = heightUnit;

		Debug.Log (scale);
		if (scale == 1.0f) {
			GUI.transform.localScale = new Vector3 ((heightUnit) / (5f),(heightUnit / 5f), 1f);
		}
		else
		{
			GUI.transform.localScale = new Vector3 ((heightUnit) / (5f*((float)Screen.width/(float)Screen.height)),(heightUnit / 5f), 1f);
		}
		

		Debug.Log (heightUnit + "    " + heightUnit);
		
		Debug.Log (Screen.height+ "height");
		Debug.Log (Screen.width+ "width");
		//GUI.transform.localScale = new Vector3 ((widthUnit) / (5f*(9f/16f)),(heightUnit / 5f), 1f);

		//Ashs shit
		GUIbar = GameObject.FindGameObjectWithTag ("Bar");
		gm = GameObject.FindObjectOfType<gameManager> ().GetComponent<gameManager>();
		lastSelPlant = gm.selPlant;
		potato = GUIbar.transform.Find ("Potato Selected").GetComponent<SpriteRenderer>();
		wheat = GUIbar.transform.Find ("Wheat Selected").GetComponent<SpriteRenderer>();
		tulip = GUIbar.transform.Find ("Tulip Selected").GetComponent<SpriteRenderer>();
		osr = GUIbar.transform.Find ("OSR Selected").GetComponent<SpriteRenderer>();
		linseed = GUIbar.transform.Find ("Linseed Selected").GetComponent<SpriteRenderer>();
		selectPlant = gm.selPlant;
		updatePlantSel ();
	}
	
	// Update is called once per frame
	void Update () {
		//ashs shit
		selectPlant = gm.selPlant;
		
		if (selectPlant != lastSelPlant) {
			updatePlantSel();
		}
		lastSelPlant = selectPlant;
	}
	
	void updatePlantSel()
	{
		switch (selectPlant) {
		case 0:
			potato.enabled = false;
			wheat.enabled = false;
			tulip.enabled = true;
			osr.enabled = false;
			linseed.enabled = false;
			break;
		case 2:
			potato.enabled = true;
			wheat.enabled = false;
			tulip.enabled = false;
			osr.enabled = false;
			linseed.enabled = false;
			break;
		case 3:
			potato.enabled = false;
			wheat.enabled = true;
			tulip.enabled = false;
			osr.enabled = false;
			linseed.enabled = false;
			break;
		case 4:
			potato.enabled = false;
			wheat.enabled = false;
			tulip.enabled = false;
			osr.enabled = true;
			linseed.enabled = false;
			break;
		case 5:
			potato.enabled = false;
			wheat.enabled = false;
			tulip.enabled = false;
			osr.enabled = false;
			linseed.enabled = true;
			break;
		default:
			break;
		}
	}
}
