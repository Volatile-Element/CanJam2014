using UnityEngine;
using System.Collections;

public class soundManager : MonoBehaviour {

	public GameObject Chicken;
	public GameObject Cow;
	public GameObject Horse;
	public GameObject Pig;

	// Use this for initialization
	void Start () 
	{
		writer ();
	}

	void writer()
	{
		int ran1 = Random.Range (0, 4);
		int ran2 = Random.Range (5, 7);
		
		StartCoroutine (Example(ran1, ran2));
	}



	IEnumerator Example(int ran1, int ran2){
		//(GameObject.Instantiate (audioTits)as GameObject).transform.parent = transform;
		yield return new WaitForSeconds(ran2);

		if (ran1 == 0)
		{
			(GameObject.Instantiate (Chicken)as GameObject).transform.parent = transform;

			writer();
		} 
		else if (ran1 == 1)
		{
			(GameObject.Instantiate (Cow)as GameObject).transform.parent = transform;

			writer();
		} 
		else if (ran1 == 2)
		{
			(GameObject.Instantiate (Horse)as GameObject).transform.parent = transform;

			writer();
		} 
		else if (ran1 == 3)
		{
			(GameObject.Instantiate (Pig)as GameObject).transform.parent = transform;

			writer();
		}


		//Destroy (GameObjectTest);
	}
}
