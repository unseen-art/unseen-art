using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Common;

public class GameInstance : MonoBehaviour
{
	void Awake()
	{
		mInstance = FindObjectOfType<GameInstance> ();
	}

	void Start ()
	{
		DontDestroyOnLoad (this);

		StartupClient startup = new StartupClient ();
		startup.RunInit ();
		startup.RunStart ();
	}

	void Update ()
	{

	}

	public static GameInstance Instance
	{
		get 
		{
			return mInstance;
		}
	}

	static GameInstance mInstance;
}
