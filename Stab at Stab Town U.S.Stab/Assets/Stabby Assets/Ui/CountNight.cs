using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CountNight : MonoBehaviour 
{

	int NightNo; //night number
	GameObject master; // Master/Gamecontroller object
	Text sText; // Store Text



	// Use this for initialization
	void Start () 
	{
		master = GameObject.FindWithTag("GameController");
		sText = GetComponent <Text> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		NightNo = master.GetComponent<Master> ().GetNight ();
		sText.text = ("Day No: " + NightNo);
	}


}
