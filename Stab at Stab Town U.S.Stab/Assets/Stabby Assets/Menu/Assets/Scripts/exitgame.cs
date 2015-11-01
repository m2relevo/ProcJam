using UnityEngine;
using System.Collections;

public class exitgame : MonoBehaviour
{

	// Use this for initialization
	public void Quit ()
	{
		Application.Quit ();
		Debug.Log ("Quit");
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}