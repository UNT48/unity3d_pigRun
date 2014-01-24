using UnityEngine;
using System.Collections;

public class FollowController : MonoBehaviour {
	
	public GameObject target;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp = new Vector3();
		temp.x = this.target.transform.position.x + 1;
		temp.z = this.target.transform.position.y + 1;
		this.transform.position = temp;
	}
}