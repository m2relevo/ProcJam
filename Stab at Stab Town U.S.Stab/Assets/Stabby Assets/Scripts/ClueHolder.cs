using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

public class ClueHolder : MonoBehaviour 
{
	public struct ClueDialogue
	{
		public string[] Attribute;
		public string[] Evidence;
	};

	public struct Clue
	{
		public GameObject clue;
		//public string name; 
		public bool used; 
		public bool found;
		public string attribute;
		public string evidence;
	};


    GameObject[] objClues;
    Clue[] Clues;
	ClueDialogue dialogue;
	bool ranUsed;
	bool isFound;

	void setDialogue()
	{
		//Items********************************************************************************
		dialogue.Attribute [1] = " has a bottle of pills";
		dialogue.Evidence [1] = "Pills were found on the body";
		dialogue.Attribute [2] = " is a known poker enthusiast";
		dialogue.Evidence [2] = "Playing cards were found on the body";
		dialogue.Attribute [3] = " has sticky fingers";
		dialogue.Evidence [3] = "Ice cream sandwich wrappers were found on the body";
		dialogue.Attribute [4] = " once went to france as a toddler";
		dialogue.Evidence [4] = "An Eiffel Tower made out of wafers was found on the body";
		dialogue.Attribute [5] = " steals Halloween decorations";
		dialogue.Evidence [5] = "Rotting pumpkins were found near the body";
		dialogue.Attribute [6] = " hugs trees";
		dialogue.Evidence [6] = "Bark was found on the body";
		dialogue.Attribute [7] = " is a big Sherlock Holmes fan";
		dialogue.Evidence [7] = "A signed picture of Sherlock Holmes was found on the body";
		dialogue.Attribute [8] = " has Pokemon Gold";
		dialogue.Evidence [8] = "A Gameboy Colour was found on the body";
		dialogue.Attribute [9] = " collects bird figurines";
		dialogue.Evidence [9] = "A tiny bird figurine was found on the body";
		dialogue.Attribute [10] = " works part time as a chef";
		dialogue.Evidence [10] = "A set of Ginsu knives were found on the body";
		//Clothing******************************************************************************
		dialogue.Attribute [11] = " is wearing a top hat";
		dialogue.Evidence [11] = "A top hat was found on the body";
		dialogue.Attribute [12] = " is wearing a leafy toupee";
		dialogue.Evidence [12] = "Leaves were found by the body";
		dialogue.Attribute [13] = "'s iron mask makes it hard to see";
		dialogue.Evidence [13] = "Nails from an iron mask were found near the body";
		dialogue.Attribute [14] = " is wearing a baseball cap made of lego";
		dialogue.Evidence [14] = "Lego bricks were found near the body";
		dialogue.Attribute [15] = " is styin' a blue polo sweater";
		dialogue.Evidence [15] = "Blue threads were found near the body";
		dialogue.Attribute [16] = " is wearing a mustard-stained t-shirt";
		dialogue.Evidence [16] = "Mustard stains were found on the body";
		dialogue.Attribute [17] = " is letting the armpits loose in a tank top";
		dialogue.Evidence [17] = "Armpit hair was found near the body";
		dialogue.Attribute [18] = " is getting horrible chafing from chainmail underpants";
		dialogue.Evidence [18] = "Chainmail links were found near the body";
		dialogue.Attribute [19] = " is snug as a bug in pajama bottoms";
		dialogue.Evidence [19] = "A pajama top was found near the body";
		dialogue.Attribute [20] = " is ready for summer in a bikini outfit";
		dialogue.Evidence [20] = "A sandy bikini top was found near the body";
		//Debris*********************************************************************************
		dialogue.Attribute [21] = " is hurt from shards of glass";
		dialogue.Evidence [21] = "Glass shards were found near the body";
		dialogue.Attribute [22] = "'s pockets have toast in them";
		dialogue.Evidence [22] = "Breadcrumbs were found near the body";
		dialogue.Attribute [23] = " is covered in paint";
		dialogue.Evidence [23] = "A bucket of paint was found near the body";
		dialogue.Attribute [24] = " possesses an empty box of cigars";
		dialogue.Evidence [24] = "Small piles of ashes were found near the body";
		dialogue.Attribute [25] = " is drinking from a cup of green tea";
		dialogue.Evidence [25] = "Wet tea leaves were found near the body";
		dialogue.Attribute [26] = "'s lighter went missing";
		dialogue.Evidence [26] = "A lighter was found on the body";
		dialogue.Attribute [27] = " has smooth skin";
		dialogue.Evidence [27] = "A bottle of moisturizer was found near the body";
		dialogue.Attribute [28] = " can't stop cleaning";
		dialogue.Evidence [28] = "The body was found scrubbed clean";
		dialogue.Attribute [29] = " stinks of alcohol";
		dialogue.Evidence [29] = "Cheap booze was found on the body";
		dialogue.Attribute [30] = "'s lipstick is looking smudged";
		dialogue.Evidence [30] = "Lipstick was found on the body";
	}

	// Use this for initialization
	void Start () 
	{
		objClues = GameObject.FindGameObjectsWithTag ("Clue");
		for (int i = 0; i<objClues.Length; i++) 
		{
			Clues[i] = new Clue{};
		/*Random gen = new Random ();
			int prob = gen.Next(100);
			if(prob < 50)//tweak depending on number of clues.
				ranUsed = true;
			else if(prob>=50)
				ranUsed = false;*/

			Clues[i].clue = objClues[i];
			Clues[i].attribute = dialogue.Attribute[int.Parse (objClues[i].name)];
			Clues[i].evidence = dialogue.Evidence[int.Parse(objClues[i].name)];
			Clues[i].used = ranUsed;
			Clues[i].found = false;
		}


	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void SetFound(int i)
	{
		Clues[i].found = true;
	}


}
