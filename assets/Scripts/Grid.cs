using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Grid : MonoBehaviour {

	public GridManager gridManager;
	public List<GameObject> list = new List<GameObject>();

	// Use this for initialization
	void Start ()
	{
		gridManager = gameObject.transform.parent.GetComponent<GridManager> ();

		for (float x = transform.position.x; x < transform.position.x + gridManager.gridWidth; x++)
		{
			for (float y = transform.position.y; y < transform.position.y + gridManager.gridHeight; y++)
			{
				int tile = 0;
				if (Random.Range (0, 10) == 9)
					tile = 3;
				else
					tile = Random.Range (1, 3);
				GameObject temp = Instantiate (gridManager.grassObject, new Vector3(x * (gridManager.spriteSize / 100), y * (gridManager.spriteSize / 100), 0), Quaternion.identity) as GameObject;
				list.Add (temp);

				temp.transform.parent = transform;
				temp.GetComponentInChildren<grassTile>().spriteType = tile;
				temp.GetComponentInChildren<grassTile>().changeSprite();

				if (x == transform.position.x || y == transform.position.y || x == (transform.position.x + (gridManager.gridWidth - 1)) || y == (transform.position.y + (gridManager.gridHeight - 1)))
				{
					temp.GetComponentInChildren<FenceTile>().gameObject.GetComponent<SpriteRenderer>().enabled = true;

					if (x == transform.position.x && y == transform.position.y)
						temp.GetComponentInChildren<FenceTile>().gameObject.GetComponent<SpriteRenderer>().sprite = gridManager.bottomLeft;
					else if (x == (transform.position.x + (gridManager.gridWidth - 1)) && y == transform.position.y)
						temp.GetComponentInChildren<FenceTile>().gameObject.GetComponent<SpriteRenderer>().sprite = gridManager.bottomRight;
					else if (x == transform.position.x && y == (transform.position.y + (gridManager.gridHeight - 1)))
						temp.GetComponentInChildren<FenceTile>().gameObject.GetComponent<SpriteRenderer>().sprite = gridManager.topLeft; //s
					else if (x == (transform.position.x + (gridManager.gridWidth - 1)) && y == (transform.position.y + (gridManager.gridHeight - 1)))
						temp.GetComponentInChildren<FenceTile>().gameObject.GetComponent<SpriteRenderer>().sprite = gridManager.topRight;
					else if (y != transform.position.y && y != (transform.position.y + (gridManager.gridHeight - 1)))
						temp.GetComponentInChildren<FenceTile>().gameObject.GetComponent<SpriteRenderer>().sprite = gridManager.side;

					//temp.GetComponentInChildren<FenceTile>().gameObject.GetComponent<SpriteRenderer>().enabled = false
				}

				/*if (Random.Range (0, 10) == 5)
					(Instantiate (gridManager.stoneObject, new Vector3(x * (gridManager.spriteSize / 100), y * (gridManager.spriteSize / 100), 0), Quaternion.identity) as GameObject).transform.parent = transform;
				else
					(Instantiate (gridManager.grassObject, new Vector3(x * (gridManager.spriteSize / 100), y * (gridManager.spriteSize / 100), 0), Quaternion.identity) as GameObject).transform.parent = transform;
*/

}
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Random.Range (0, 200) == 149)
		{
			plantTile[] pta = GetComponentsInChildren<plantTile> ();
			plantTile pt = pta[Random.Range (0, pta.Length)];

			if(pt.gameObject.transform.parent.GetComponentInChildren<grassTile>().spriteType > 2 || pt.gameObject.transform.parent.GetComponentInChildren<FenceTile>().gameObject.GetComponent<SpriteRenderer>().enabled == true)
				return;

			if (pt.plantType == 1)
				return;
			
			pt.growState = 0;
			pt.plantType = 1;
			pt.spritePicker (pt.plantType);
			
			pt.isGrowing = true;
		}
	}
}
