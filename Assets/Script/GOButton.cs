using UnityEngine;
using System.Collections;

public class GOButton : MonoBehaviour {

	public Texture ButtonImageRetry;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	// GUI描画.
	void OnGUI() {
		
		//Rect rect_rules = new Rect(140, 300, 150, 100);
		Rect rect_retry = new Rect(390, 300, 150, 100);

		bool isClicked_retry = GUI.Button(rect_retry, ButtonImageRetry, "fixedWidth");
		
		// click rules button
		if (isClicked_retry){
			// jump rules
			Application.LoadLevel("title");
			
		}
	}
}
