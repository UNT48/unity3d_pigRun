using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	private int score;

	// Use this for initialization
	void Start () {
		score = PlayerPrefs.GetInt ("score");
		guiText.text = score + " m";
	}
	
	// Update is called once per frame
	void Update () {
		//to Title.
		if (Input.GetKeyDown("space")) {
			Application.LoadLevel("Title");
		}
	}

}
