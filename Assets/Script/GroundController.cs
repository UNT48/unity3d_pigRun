using UnityEngine;
using System.Collections;

public class GroundController : MonoBehaviour {

	private int _moveScale = 155;

	void Start () {
	
	}

	void Update () {
	
	}

	void OnBecameInvisible () {
		Vector3 floor_position = this.transform.position;
		floor_position.x += _moveScale;
		this.transform.position = floor_position;
	}
}