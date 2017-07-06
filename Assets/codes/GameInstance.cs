using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using common;

public class GameInstance : MonoBehaviour {

	void Awake() {
		instance = FindObjectOfType<GameInstance> ();

		StartupClient startup = new StartupClient ();
		startup.RunInit ();
		startup.RunStart ();
	}

	void Start () {
		DontDestroyOnLoad (this);
	}

	void Update () {
		
	}

	public static GameInstance Instance {
		get {
			return instance;
		}
	}

	static GameInstance instance;

}
