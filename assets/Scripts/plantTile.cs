using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class plantTile : MonoBehaviour {
	
	private spriteManager sm;
	private gameManager gm;
	private float growCounter;
	public int growState;
	public int plantType;
	public int seedCount;
	public int harvestScore;
	private int growTimes;
	private List<Sprite> selectedPlant;
	public bool isGrowing = false;
	public bool harvested = true;
	
	// Use this for initialization
	void Start () {
		gm = GameObject.FindObjectOfType<gameManager> ().GetComponent<gameManager>();
		sm = GameObject.FindObjectOfType<spriteManager> ().GetComponent<spriteManager>();
		growTimes = Random.Range(5,15);
		//spritePicker ();
	}
	
	// Update is called once per frame
	void Update () {
		if (isGrowing == true) 
		{
			 growCounter = growCounter + Time.deltaTime;
				if (growCounter > growTimes) {
						if (growState <= 2) {
								growState++;
						}
						updateGrowState ();
						growCounter = 0;
				} 
		}

		if (growState != 2)
			return;
		
		if (Random.Range(0, 50) == 49)
		{
			RaycastHit hit;
			
			int side = Random.Range (0, 4);
			plantTile pt;
			Vector3 origin = Vector3.zero;
			
			switch(side)
			{
			case 0:
				origin = new Vector3(transform.position.x + 1.28f, transform.position.y, 10);
				break;
			case 1:
				origin = new Vector3(transform.position.x - 1.28f, transform.position.y, 10);
				break;
			case 2:
				origin = new Vector3(transform.position.x, transform.position.y + 1.28f, 10);
				break;
			case 3:
				origin = new Vector3(transform.position.x, transform.position.y - 1.28f, 10);
				break;
			}
			
			if (Physics.Raycast(origin, new Vector3(0, 0, -15), out hit) == true)
			{
				try
				{
					if (hit.collider.gameObject.GetComponentInChildren<grassTile>().spriteType > 2)
						return;

					if (hit.collider.gameObject.transform.parent.GetComponentInChildren<FenceTile>().sr.enabled == false)
					{
						Debug.Log ("No");
						return;
					}

						pt = hit.collider.gameObject.GetComponentInChildren<plantTile>();

					//Specific Plant Shenanigans
					switch(plantType)
					{
					case 0:
						Plant0Stuff(hit.collider.gameObject.GetComponentInChildren<plantTile>());
						break;
					case 1:
						Plant1Stuff(hit.collider.gameObject.GetComponentInChildren<plantTile>());
						break;
					case 2:
						Plant2Stuff(hit.collider.gameObject.GetComponentInChildren<plantTile>());
						break;
					case 3:
						Plant3Stuff(hit.collider.gameObject.GetComponentInChildren<plantTile>());
						break;
					case 4:
						Plant4Stuff(hit.collider.gameObject.GetComponentInChildren<plantTile>());
						break;
					case 5:
						Plant5Stuff(hit.collider.gameObject.GetComponentInChildren<plantTile>());
						break;
					}
				}
				catch
				{
					return;
				}
			}
		}
	}

	public void typechange()
	{
		plantType = gm.selPlant;
		spritePicker (plantType);
	}

	public void spritePicker(int plantTypePass){
		float sproutRand = Random.Range (0, 100);
		sproutRand = sproutRand / 100;
		switch (plantTypePass) {
		case 1:
			if(sproutRand < 0.4)
			{
				selectedPlant = sm.weed1;
			}
			else if(sproutRand < 0.8)
			{
				selectedPlant = sm.weed2;
			}
			else
			{
				selectedPlant = sm.weed3;
			}
			break;
		case 2:
			if(sproutRand < 0.4)
			{
				selectedPlant = sm.potato1;
				harvestScore = 1;
				seedCount = 0;
			}
			else if(sproutRand < 0.8)
			{
				selectedPlant = sm.potato2;
				harvestScore = 2;
				seedCount = 0;
			}
			else
			{
				selectedPlant = sm.potato3;
				harvestScore = 3;
				seedCount = 0;
			}
			break;
		case 3:
			if(sproutRand < 0.4)
			{
				selectedPlant = sm.wheat1;
				harvestScore = 1;
				seedCount = 0;
			}
			else if(sproutRand < 0.8)
			{
				selectedPlant = sm.wheat2;
				harvestScore = 2;
				seedCount = 0;
			}
			else
			{
				selectedPlant = sm.wheat3;
				harvestScore = 3;
				seedCount = 1;
			}
			break;
		case 4:
			if(sproutRand < 0.4)
			{
				selectedPlant = sm.osr1;
				harvestScore = 1;
				seedCount = 0;
			}
			else if(sproutRand < 0.8)
			{
				selectedPlant = sm.osr2;
				harvestScore = 2;
				seedCount = 1;
			}
			else
			{
				selectedPlant = sm.osr3;
				harvestScore = 3;
				seedCount = 4;
			}
			break;
		case 5:
			if(sproutRand < 0.4)
			{
				selectedPlant = sm.linseed1;
				harvestScore = 1;
				seedCount = 0;
			}
			else if(sproutRand < 0.8)
			{
				selectedPlant = sm.linseed2;
				harvestScore = 2;
				seedCount = 2;
			}
			else
			{
				selectedPlant = sm.linseed3;
				harvestScore = 3;
				seedCount = 5;
			}
			break;
		case 0:
			if(sproutRand < 0.4)
			{
				selectedPlant = sm.tulip1;
				harvestScore = 1;
				seedCount = 0;
			}
			else if(sproutRand < 0.8)
			{
				selectedPlant = sm.tulip2;
				harvestScore = 2;
				seedCount = 0;
			}
			else
			{
				selectedPlant = sm.tulip3;
				harvestScore = 3;
				seedCount = 3;
			}
			break;
			
			
		}
		
		updateGrowState();
	}
	
	void updateGrowState()
	{
		switch (growState) {
		case 0:
			gameObject.GetComponent<SpriteRenderer> ().sprite = selectedPlant [0];
			break;
		case 1:
			gameObject.GetComponent<SpriteRenderer> ().sprite = selectedPlant [1];
			break;
		case 2:
			gameObject.GetComponent<SpriteRenderer> ().sprite = selectedPlant [2];
			break;
		}
	}


	public void Plant0Stuff(plantTile pt)
	{
		if (pt.plantType != 4)
			return;
		
		pt.growState = 0;
		pt.plantType = 0;
		pt.spritePicker (pt.plantType);
		
		pt.isGrowing = true;
	}

	public void Plant1Stuff(plantTile pt)
	{
		if (pt.plantType == 1)
			return;
		
		pt.growState = 0;
		//pt.plantType = 1;
		pt.spritePicker (1);
		
		pt.isGrowing = true;
	}

	public void Plant2Stuff(plantTile pt)
	{
		if (pt.plantType != 3)
			return;
		
		pt.growState = 0;
		pt.plantType = 2;
		pt.spritePicker (pt.plantType);
		
		pt.isGrowing = true;
	}

	public void Plant3Stuff(plantTile pt)
	{
		if (pt.plantType != 0)
			return;
		
		pt.growState = 0;
		pt.plantType = 3;
		pt.spritePicker (pt.plantType);
		
		pt.isGrowing = true;
	}

	public void Plant4Stuff(plantTile pt)
	{
		if (pt.plantType != 5)
			return;
		
		pt.growState = 0;
		pt.plantType = 4;
		pt.spritePicker (pt.plantType);
		
		pt.isGrowing = true;
	}

	public void Plant5Stuff(plantTile pt)
	{
		if (pt.plantType != 2)
			return;
		
		pt.growState = 0;
		pt.plantType = 5;
		pt.spritePicker (pt.plantType);
		
		pt.isGrowing = true;
	}
}