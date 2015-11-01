using UnityEngine;
using System.Collections;

public class CharacterHolder : MonoBehaviour 
{
    public struct Character
	{
		public GameObject character;
		public string name;
		public bool Used;
		public bool Murderer;
		public ClueHolder.Clue C1;
		public ClueHolder.Clue C2;
		public ClueHolder.Clue C3;
		public ClueHolder.Clue C4;
		public ClueHolder.Clue C5;

	}

	GameObject[] objChar;
	Character[] Characters;
	bool ranUsed = false;
	bool murder = false;
	int count = 0;

	// Use this for initialization
	void Start () 
	{
		objChar = GameObject.FindGameObjectsWithTag ("Character");
		for (int i = 0; i<objChar.Length; i++) 
		{

			int prob = Random.Range(0, 100);
			if(prob < 50 && count<5)// picks what ones are used in scene
			{
				ranUsed = true;
			    count++;
			}
			else if(prob>=50 || count>=5)
			{
				ranUsed = false;
			}
			Characters[i].character = objChar[i];
			Characters[i].name = objChar[i].name;
			Characters[i].Used = ranUsed;
			if(ranUsed == true)// pick from 5
			{
				int prob2 = Random.Range(0, 100);
				if(prob2 < 20 && murder == false)// pick muderer
				{
					murder = true;
				}
				else if(prob2 >= 20)
				{
					murder = false;
				}
			}
			Characters[i].Murderer = murder;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
