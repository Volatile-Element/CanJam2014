using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour
{
	GridManager gridManager;
	gameManager GameManager;

	public int maxSpeed = 1;

	Animator anim;

	// Use this for initialization
	void Start ()
	{
		gridManager = GameObject.FindObjectOfType<GridManager> ();
		GameManager = GameObject.FindObjectOfType<gameManager> ();

		anim = GetComponent<Animator> ();
	}

	void Update()
	{
		CameraFollowPlayer ();

		if(Input.GetKeyDown(KeyCode.E))
		{
			RaycastHit hit;
			if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y-0.64f, 10), new Vector3(0, 0, -15), out hit) == true)
			{
				Debug.Log (hit.collider.gameObject.name);

				plantTile pt = hit.collider.gameObject.GetComponentInChildren<plantTile>();
				if(pt.isGrowing == true)
				{
					//harvesting
					if(pt.growState == 2)
					{
						int type = pt.plantType;
						switch(type)
						{
						case 0:
							GameManager.tulip += pt.harvestScore;
							GameManager.seeds += pt.seedCount;
							break;
						case 2:
							GameManager.potatoes += pt.harvestScore;
							GameManager.seeds += pt.seedCount;
							break;
						case 3:
							GameManager.wheat += pt.harvestScore;
							GameManager.seeds += pt.seedCount;
							break;
						case 4:
							GameManager.osr += pt.harvestScore;
							GameManager.seeds += pt.seedCount;
							break;
						case 5:
							GameManager.linseed += pt.harvestScore;
							GameManager.seeds += pt.seedCount;
							break;
						default:
							break;
						}
					}
					pt.isGrowing = false;
					pt.harvested = true;
					pt.growState = 0;
					pt.GetComponent<SpriteRenderer>().sprite = null;
				}
				else
				{
					int seedReq = 0;
					//planting
					switch(GameManager.selPlant)
					{
					case 0:
						seedReq = 3;
						break;
					case 2:
						seedReq = 1;
						break;
					case 3:
						seedReq = 2;
						break;
					case 4:
						seedReq = 4;
						break;
					case 5:
						seedReq = 5;
						break;
					}
					if(GameManager.seeds > seedReq)
					{
						GameManager.seeds -= seedReq;
						pt.isGrowing = true;
						pt.harvested = false;
					 	pt.plantType = GameManager.selPlant;
					 	pt.spritePicker(pt.plantType);
					}
					
				}
			}
		}

		if(Input.GetKeyDown(KeyCode.Alpha1))
		{
			Debug.Log("YEAH!");
			GameManager.selPlant = 2;
		}
		else if(Input.GetKeyDown(KeyCode.Alpha2))
		{
			Debug.Log("YEAH!");
			GameManager.selPlant = 3;
		}
		else if(Input.GetKeyDown(KeyCode.Alpha3))
		{
			Debug.Log("YEAH!");
			GameManager.selPlant = 0;
		}
		else if(Input.GetKeyDown(KeyCode.Alpha4))
		{
			Debug.Log("YEAH!");
			GameManager.selPlant = 4;
		}
		else if(Input.GetKeyDown(KeyCode.Alpha5))
		{
			Debug.Log("YEAH!");
			GameManager.selPlant = 5;
		}
		//RaycastHit hit2;

		//Debug.DrawRay (new Vector3 (transform.position.x + 1.28f, transform.position.y, 10), new Vector3 (0, 0, -15));

		//if (Physics.Raycast(new Vector3(transform.position.x + 1.28f, transform.position.y, 10), new Vector3(0, 0, -15), out hit2))
			//Debug.Log(hit2.collider.gameObject.name);
	}

	// Update is called once per frame
	void FixedUpdate ()
	{
		anim.SetFloat ("SpeedX", Input.GetAxis ("Horizontal") * maxSpeed);
		anim.SetFloat ("SpeedY", Input.GetAxis ("Vertical") * maxSpeed);

		rigidbody.velocity = new Vector2 (Input.GetAxis ("Horizontal") * maxSpeed, rigidbody.velocity.y);
		rigidbody.velocity = new Vector2 (rigidbody.velocity.x, Input.GetAxis ("Vertical") * maxSpeed);

		Debug.DrawRay (new Vector3 (transform.position.x, transform.position.y - 0.64f, 10), new Vector3 (0, 0, -15));
		if (Input.GetKeyDown (KeyCode.Return))
		{
			RaycastHit hit;

			if (Physics.Raycast(new Vector3(transform.position.x + 2.56f, transform.position.y, 10), new Vector3(0, 0, -15), out hit) == false)
			{
				Debug.Log ("Right");
				//gridManager.CreateGrid (new Vector3(transform.position.x + 1.28f, transform.position.y, 10));

				if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y, 10), new Vector3(0, 0, -15), out hit) == true)
				{
					Debug.Log (hit.collider.gameObject.name);

					Vector3 temp = hit.collider.gameObject.transform.parent.transform.position;
					gridManager.CreateGrid (new Vector3(temp.x + (((gridManager.spriteSize / 100f) * (gridManager.gridWidth - 1)) - ((gridManager.spriteSize / 100f)) - ((gridManager.spriteSize / 100f) / 4)), temp.y, temp.z));
					GameManager.farmCount += 1;
					//gridManager.CreateGrid (new Vector3(temp.x + (gridManager.spriteSize / 100f) * , temp.y, temp.z));

					//Delete Fences Code

					//Grid grid = hit.collider.transform.parent.GetComponent<Grid>();

					//for (int x = 0; x < (int)grid.gridManager.gridWidth; x++)
					//{
						//for (int y = 0; y < (int)grid.gridManager.gridHeight; y++)
						//{
							//grid.list[x * y + x].GetComponentInChildren<FenceTile>().gameObject.GetComponent<SpriteRenderer>().enabled = false;
							//hit.collider.gameObject.GetComponentInChildren<FenceTile>().gameObject.GetComponent<SpriteRenderer>().enabled = false;
						//}
					//}

//					//Scans up and Down.
//					Transform parent = hit.collider.transform.parent;
//
//					for (int i = 0; i <= 10; i++)
//					{
//						if (Physics.Raycast(new Vector3(transform.position.x + 1.28f, transform.position.y + (1.28f * i), 10), new Vector3(0, 0, -15), out hit) == true)
//						{
//							if (hit.collider.transform.parent != parent)
//								break;
//
//							try
//							{
//								Debug.Log ("Hit");
//								hit.collider.gameObject.GetComponentInChildren<FenceTile>().gameObject.GetComponent<SpriteRenderer>().enabled = false;
//							}
//							catch{break;}
//						}
//					}
//
//					for (int i = 1; i <= 10; i++)
//					{
//						if (Physics.Raycast(new Vector3(transform.position.x + 1.28f, transform.position.y + (1.28f * -i), 10), new Vector3(0, 0, -15), out hit) == true)
//						{
//							if (hit.collider.transform.parent != parent)
//								break;
//							
//							try
//							{
//								Debug.Log ("Hit");
//								hit.collider.gameObject.GetComponentInChildren<FenceTile>().gameObject.GetComponent<SpriteRenderer>().enabled = false;
//							}
//							catch{break;}
//						}
//					}
				}
			}

			if (Physics.Raycast(new Vector3(transform.position.x - 2.56f, transform.position.y, 10), new Vector3(0, 0, -15), out hit) == false)
			{
				Debug.Log ("Left");
				//gridManager.CreateGrid (new Vector3(transform.position.x - 1.28f, transform.position.y, 10));

				if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y, 10), new Vector3(0, 0, -15), out hit) == true)
				{
					Debug.Log (hit.collider.gameObject.name);

					Vector3 temp = hit.collider.gameObject.transform.parent.transform.position;
					gridManager.CreateGrid (new Vector3(temp.x - (((gridManager.spriteSize / 100f) * (gridManager.gridWidth - 1)) - ((gridManager.spriteSize / 100f)) - ((gridManager.spriteSize / 100f) / 4)), temp.y, temp.z));
					GameManager.farmCount += 1;
					//gridManager.CreateGrid (new Vector3(temp.x + (gridManager.spriteSize / 100f) * , temp.y, temp.z));
				}
			}

			if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y + 2.56f, 10), new Vector3(0, 0, -15), out hit) == false)
			{
				Debug.Log ("Up");
				//gridManager.CreateGrid (new Vector3(transform.position.x, transform.position.y + 1.28f, 10));

				if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y - 0.64f, 10), new Vector3(0, 0, -15), out hit) == true)
				{
					Debug.Log (hit.collider.gameObject.name);

					Vector3 temp = hit.collider.gameObject.transform.parent.transform.position;
					gridManager.CreateGrid (new Vector3(temp.x, temp.y + (((gridManager.spriteSize / 100f) * (gridManager.gridWidth - 1)) - ((gridManager.spriteSize / 100f)) - ((gridManager.spriteSize / 100f) / 4)), temp.z));
					GameManager.farmCount += 1;
					//gridManager.CreateGrid (new Vector3(temp.x + (gridManager.spriteSize / 100f) * , temp.y, temp.z));
				}
			}

			if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y - 2.56f, 10), new Vector3(0, 0, -15), out hit) == false)
			{
				Debug.Log ("Down");
				//gridManager.CreateGrid (new Vector3(transform.position.x, transform.position.y - 1.28f, 10));

				if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y, 10), new Vector3(0, 0, -15), out hit) == true)
				{
					Debug.Log (hit.collider.gameObject.name);

					Vector3 temp = hit.collider.gameObject.transform.parent.transform.position;
					gridManager.CreateGrid (new Vector3(temp.x, temp.y - (((gridManager.spriteSize / 100f) * (gridManager.gridHeight - 1)) - ((gridManager.spriteSize / 100f)) - ((gridManager.spriteSize / 100f) / 4)), temp.z));
					GameManager.farmCount += 1;
					//gridManager.CreateGrid (new Vector3(temp.x + (gridManager.spriteSize / 100f) * , temp.y, temp.z));;
				}
			}
		}
	}

	void CameraFollowPlayer()
	{
		Camera.main.transform.position = new Vector3 (transform.position.x, transform.position.y, Camera.main.transform.position.z);
	}
}
