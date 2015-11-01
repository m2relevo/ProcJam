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
		public ClueHolder.Clue[] C;


	}

	GameObject[] objChar;
	Character[] Characters;
	bool ranUsed = false;
	bool murder = false;
	int count = 0;
	int evidenceCount = 0;
	ClueHolder.Clue[] MurderC;
	ClueHolder.Clue[] AllClues;

	// Use this for initialization
	void Start () 
	{
		MurderC = GetComponent<ClueHolder> ().MurderClues ();
		AllClues = GetComponent<ClueHolder> ().ListClue ();
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
					Characters[i].C[0] = MurderC[0];
					Characters[i].C[1] = MurderC[1];
					Characters[i].C[2] = MurderC[2];
					Characters[i].C[3] = MurderC[3];
					Characters[i].C[4] = MurderC[4];
				}
				else if(prob2 >= 20)
				{
					int evidenceProb = Random.Range (0,29);
					murder = false;
					Characters[i].C[0] = MurderC[0];
					Characters[i].C[1] = MurderC[1];
					Characters[i].C[2] = MurderC[2];
					Characters[i].C[3] = MurderC[3];
					Characters[i].C[4] = MurderC[4];


					Characters[i].C[evidenceCount] =  AllClues[evidenceProb]; 
						evidenceCount++;
				}
			}
			Characters[i].Murderer = murder;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
