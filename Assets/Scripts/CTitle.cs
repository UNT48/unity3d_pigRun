using UnityEngine;
using System.Collections;

public class CTitle : MonoBehaviour {

	public Texture ButtonImage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

//		if(Input.GetButton("Jump")) {
//			Application.LoadLevel("Rules");
//		}

//		// click start
//		if(Input.GetButton("Jump")) {
//			Application.LoadLevel("Main");
//		}

//		// click rules
//		if(Input.GetMouseButtonDown(0)) {
//			Application.LoadLevel("Rules");
//		}

	}

	// GUI描画
	void OnGUI() {

		Rect rect_rules = new Rect(100, 230, 150, 100);
		bool isClicked_rules = GUI.Button(rect_rules, ButtonImage, "fixedWidth");

//		bool isClicked_rules = GUI.Button(rect_rules, new GUIContent("Push!!", ButtonImage), "fixedWidth");


		// click rules button
		if (isClicked_rules){
			// jump rules
			Application.LoadLevel("Rules");

		}

		Rect rect_start = new Rect(350, 230, 150, 100);
		bool isClicked_start = GUI.Button(rect_start, ButtonImage, "fixedWidth");

		// click start button
		if (isClicked_start){
		// jump main
			Application.LoadLevel("Main");
		}

	}


}
