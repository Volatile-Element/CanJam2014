using UnityEngine;
using System.Collections;

public class inhouseSound : MonoBehaviour {

	public int waiter = 5;

	// Use this for initialization
	void Start () {
		StartCoroutine (Example());
	}

	IEnumerator Example(){
		yield return new WaitForSeconds(waiter);
		
		Destroy(this.gameObject);
	}
}
