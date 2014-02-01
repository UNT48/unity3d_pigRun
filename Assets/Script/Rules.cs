using UnityEngine;
using System.Collections;

public class Rules : MonoBehaviour {

	public Texture ButtonImage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI(){

		float sw = Screen.width;
		float sh = Screen.height;

		Rect rect = new Rect(sw * 7 / 8, 0, sw * 1 / 8, sw * 1 / 8);
		bool isClicked = GUI.Button(rect, ButtonImage, "");

		if (isClicked){
			// jump title
			Application.LoadLevel("Title");			
		}
	}

}
