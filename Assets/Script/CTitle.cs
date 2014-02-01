using UnityEngine;
using System.Collections;

public class CTitle : MonoBehaviour {

	public Texture ButtonImageRules;
	public Texture ButtonImageLevel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	// GUI描画
	void OnGUI() {

		float sw = Screen.width;
		float sh = Screen.height;

		Rect rect_rules = new Rect(sw * 1 / 8, sh * 3 / 4, sw * 1 / 4, sh * 1 / 4);
		bool isClicked_rules = GUI.Button(rect_rules, ButtonImageRules, "");

		// click rules button
		if (isClicked_rules){
			// jump rules
			Application.LoadLevel("Rules");

		}

		Rect rect_start = new Rect(sw * 5 / 8, sh * 3 / 4, sw * 1 / 4, sh * 1 / 4);
		bool isClicked_start = GUI.Button(rect_start, ButtonImageLevel, "");

		// click start button
		if (isClicked_start){
		// jump main
			Application.LoadLevel("Level");
		}

	}


}
