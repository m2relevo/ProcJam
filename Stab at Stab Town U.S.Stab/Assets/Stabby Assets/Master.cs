using UnityEngine;
using System.Collections;

public class Master : MonoBehaviour 
{
	int NightNo = 1;
	

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void SetNight()
	{
		NightNo++;
	}

	public int GetNight()
	{
		return NightNo;
	}
}
