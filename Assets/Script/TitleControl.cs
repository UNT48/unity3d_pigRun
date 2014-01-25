using UnityEngine;
using System.Collections;

public class TitleControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")) {
			Application.LoadLevel("Level");
		}

		if (Input.touchCount > 0) {
			Application.LoadLevel("Level");
		}
	}
}
