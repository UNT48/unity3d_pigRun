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

		Rect rect = new Rect(570, 0, 80, 80);
		bool isClicked = GUI.Button(rect, ButtonImage, "fixedWidth");

		if (isClicked){
			// jump title
			Application.LoadLevel("Title");			
		}
	}

}
