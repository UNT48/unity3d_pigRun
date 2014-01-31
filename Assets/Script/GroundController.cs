using UnityEngine;
using System.Collections;

public class GroundController : MonoBehaviour {

	public GameObject[] ground;

	private float _moveScale = 232.5f;

	void OnBecameInvisible () {
		int randNum = 0;
		Vector3 floor_position = this.transform.position;

		floor_position.x += _moveScale;
		randNum = Random.Range(0, ground.Length);

		Instantiate (ground[randNum], floor_position, this.transform.rotation);

		Destroy (this.gameObject);
	}

	void OnApplicationQuit ()
	{
		Debug.Log (this.gameObject.name + " OnApplicationQuit");
		Destroy (gameObject);
	}
}