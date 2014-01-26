using UnityEngine;
using System.Collections;

public class Rules : MonoBehaviour {

	public Texture ButtonImage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

//		if(Input.GetButton("Jump")) {
//			Application.LoadLevel("Title");
//		}
		
		// click rules
//		if(Input.GetMouseButtonDown(0)) {
//			Application.LoadLevel("Title");
//		}

	}

//	var btnTexture : Texture;

	void OnGUI(){

//		if (!btnTexture) {
//			Debug.LogError("Please assign a texture on the inspector");
//			return;
//		}

		Rect rect = new Rect(520, 0, 80, 80);

//		bool isClicked = GUI.Button(rect, new GUIContent("Push!!", ButtonImage));
		bool isClicked = GUI.Button(rect, ButtonImage, "fixedWidth");

		if (isClicked){
			// jump title
			Application.LoadLevel("Title");			
		}
	}

}
