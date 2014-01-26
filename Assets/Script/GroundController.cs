using UnityEngine;
using System.Collections;

public class GroundController : MonoBehaviour {

	public GameObject[] ground;

	private int _moveScale = 155;

	void OnBecameInvisible () {
	
		Vector3 floor_position = this.transform.position;
		floor_position.x += _moveScale;

		Instantiate (this.ground[Random.Range(0, ground.Length)], floor_position, this.transform.rotation);

		Destroy (this.gameObject);
	}
}