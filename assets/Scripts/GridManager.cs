using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GridManager : MonoBehaviour
{
	public GameObject grassObject;

	public List<Grid> gridList = new List<Grid>();

	public float gridWidth = 10;
	public float gridHeight = 10;
	public float spriteSize = 128;

	public Sprite fence;
	public Sprite topLeft;
	public Sprite topRight;
	public Sprite bottomLeft;
	public Sprite bottomRight;
	public Sprite side;

	// Use this for initialization
	void Start ()
	{
		CreateGrid ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	}

	public void CreateGrid()
	{
		GameObject grid = new GameObject ("Grid");
		grid.transform.parent = transform;
		gridList.Add (grid.GetComponent<Grid>());

		grid.AddComponent<Grid> ();
	}

	public void CreateGrid(Vector3 startPosition)
	{
		GameObject grid = new GameObject ("Grid");
		grid.transform.parent = transform;
		grid.transform.position = startPosition;

		grid.AddComponent<Grid> ();
		gridList.Add (grid.GetComponent<Grid>());
	}
}
