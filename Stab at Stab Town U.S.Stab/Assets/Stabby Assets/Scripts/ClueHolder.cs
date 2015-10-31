using UnityEngine;
using System.Collections;

public class ClueHolder : MonoBehaviour 
{
	public struct Clue
	{
		public GameObject clue;
		public bool used; 
		public bool found;
	};

    GameObject[] objClues;
    Clue[] Clues;
	bool ranUsed;
	bool isFound;



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
