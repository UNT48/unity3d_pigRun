using UnityEngine;
using System.Collections;

public class BackImgController : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnBecameInvisible () {
		Vector3 floor_position = this.transform.position;
		//floor_position.x += this.transform.localScale.x;
		floor_position.x += 155;
		this.transform.position = floor_position;
	}
}