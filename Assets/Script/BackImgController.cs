using UnityEngine;
using System.Collections;

public class BackImgController : MonoBehaviour {

	void OnBecameInvisible () {
		Vector3 floor_position = this.transform.position;
		floor_position.x += 232.5f;
		this.transform.position = floor_position;
	}
}