using UnityEngine;
using System.Collections;

public class changescene : MonoBehaviour {

	// Use this for initialization
	public void Changescene (int changescene)
	{
		Application.LoadLevel (changescene);
		Debug.Log ("Hey");
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
