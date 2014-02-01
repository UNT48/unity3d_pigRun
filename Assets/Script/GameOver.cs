using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")) {
			Application.LoadLevel("Title");
		}
	}

	/*void OnGUI() {
		GUI.Label(new Rect(0,0,100,20),"タイトル");
	}*/

}
