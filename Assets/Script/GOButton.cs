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

		float sw = Screen.width;
		float sh = Screen.height;

		Rect rect_retry = new Rect(sw * 5 / 8, sh * 3 / 4, sw * 1 / 4, sh * 1 / 4);

		bool isClicked_retry = GUI.Button(rect_retry, ButtonImageRetry, "");
		
		// click retry button.
		if (isClicked_retry){
			// jump title
			Application.LoadLevel("title");
		}
	}
}
