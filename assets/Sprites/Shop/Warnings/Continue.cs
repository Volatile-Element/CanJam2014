using UnityEngine;
using System.Collections;

public class Continue : MonoBehaviour {
	public GameObject Warnings;
	public GameObject Fund;
	public GameObject Linseed;
	public GameObject OSR;
	public GameObject Potato;
	public GameObject Tulip;
	public GameObject Wheat;
	void OnMouseUpAsButton()
	{
		Warnings.SetActive (false);
		Fund.SetActive (false);
		Linseed.SetActive (false);
		OSR.SetActive (false);
		Potato.SetActive (false);
		Tulip.SetActive (false);
		Wheat.SetActive (false);
	}
}
