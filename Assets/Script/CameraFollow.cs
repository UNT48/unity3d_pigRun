 using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour 
{
	public float xMargin = 1f;		// Distance in the x axis the player can move before the camera follows.
	public float yMargin = 1f;		// Distance in the y axis the player can move before the camera follows.
	public float xSmooth = 8f;		// How smoothly the camera catches up with it's target movement in the x axis.
	public float ySmooth = 8f;		// How smoothly the camera catches up with it's target movement in the y axis.
	public Vector2 maxXAndY;		// The maximum x and y coordinates the camera can have.
	public Vector2 minXAndY;		// The minimum x and y coordinates the camera can have.
	private Transform player;		// Reference to the player's transform.

	void Awake ()
	{
		// Setting up the reference.
		player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	void FixedUpdate ()
	{
		TrackPlayer();
	}
	
	void TrackPlayer ()
	{
		float targetX = player.position.x;
		//float targetY = player.position.y;

		//Debug.Log( "targetX : " + targetX );
		//Debug.Log( "targetY : " + targetY );
		//Debug.Log( "timeDelta : " + Time.deltaTime );

		// The target x and y coordinates should not be larger than the maximum or smaller than the minimum.
		//targetX = Mathf.Clamp(targetX, minXAndY.x, maxXAndY.x);
		//targetY = Mathf.Clamp(targetY, minXAndY.y, maxXAndY.y);

		// Set the camera's position to the target position with the same z component.
		//transform.position = new Vector3(targetX + 10, targetY + 3, transform.position.z);
		transform.position = new Vector3(targetX + 10, transform.position.y, transform.position.z);
	}
}
