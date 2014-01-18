using UnityEngine;
using System.Collections;

public class BGController_pigrun : MonoBehaviour {

	// カメラ.
	private GameObject		main_camera = null;

	// hero.
	private GameObject[]		hero = null;
	
	// 初期位置.
	private Vector3	initial_position;

	// 床の幅（X方向）.
	public	static float	WIDTH = 10.0f*4.0f;

	// 床モデルの数.
	public static int		MODEL_NUM = 3;

	// Use this for initialization
	void Start () {
		Debug.Log ("BGC--Start--");

		// カメラのインスタンスを探しておく.
		this.main_camera = GameObject.FindGameObjectWithTag("MainCamera");

		this.hero = GameObject.FindGameObjectsWithTag("Player");
		
		this.initial_position = this.transform.position;
		
		//this.renderer.enabled = SceneControl.IS_DRAW_DEBUG_FLOOR_MODEL
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("BGC--Update--",total_width);
		//Debug.Log ("BGC--start--");

		// 背景全体（すべてのモデルを並べた）の幅.
		//
		//float	total_width = BGController_pigrun.WIDTH*BGController_pigrun.MODEL_NUM;
		float total_width = BGController_pigrun.WIDTH;

		// 背景の位置.
		Vector3	floor_position = this.transform.position;

		// カメラの位置.
		Vector3	camera_position = this.main_camera.transform.position;

		// hero position.
		Vector3 hero_position = this.hero[0].transform.position;

		Debug.Log ("BGC--Update--");
		Debug.Log (total_width);
		Debug.Log (floor_position);
		//Debug.Log (camera_position);
		Debug.Log (hero_position);

		//  if(floor_position.x + total_width/2.0f < camera_position.x) {
		if(floor_position.x + total_width/2.0f < hero_position.x) {
			Debug.Log ("BGC--Quater--");
			
			// 前にワープ.
			floor_position.x += total_width;
			
			this.transform.position = floor_position;
		}
	
	}
}
