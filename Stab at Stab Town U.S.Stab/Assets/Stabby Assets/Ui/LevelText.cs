using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelText : MonoBehaviour {

	string Level;
	Text lText;


/*	struct Character
	{
		GameObject character;
		Clue item1;
		Clue item2;
		Clue item3;
		Clue item4;
		Clue item5;
	}*/

	// Use this for initialization
	void Start () 
	{ 

	    Level = Application.loadedLevelName;
		lText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		lText.text = Level;
	}

	void ReName()
	{
		Level = Application.loadedLevelName;
	}
}
