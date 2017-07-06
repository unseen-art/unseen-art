using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInstance : MonoBehaviour {

	public static GameInstance Instance {
		get {
			if (null == instance) {
				instance = FindObjectOfType<GameInstance> ();
			}
			return instance;
		}
	}

	static GameInstance instance;

	void Awake() {
	}

	void Start () {
		
	}

	void Update () {
		
	}
}
