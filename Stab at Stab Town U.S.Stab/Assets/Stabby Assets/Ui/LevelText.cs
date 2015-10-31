using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelText : MonoBehaviour {

	string Level;
	Text lText;

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
