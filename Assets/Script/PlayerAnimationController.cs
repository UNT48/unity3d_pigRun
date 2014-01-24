using UnityEngine;
using System.Collections;

public class PlayerAnimationController : MonoBehaviour {
	// playerのObject.
	public GameObject Player;
	// アニメーション用Sprite配列.
	public Sprite[] PigSprite;
	// Sprite制御クラス.
	private SpriteRenderer spRender;

	// アニメーション差し替えタイミング計測用時間.
	private float time;
	// アニメーション切替間隔.
	private const float ANIM_CYCLE_TIME	= 0.2f;
	// アニメーション番号.
	private int animNum;
	// groundCheck.
	private Transform groundCheck;
	// 地面にいるかどうか.
	private bool isGrounded;
	// ジャンプ用フラグ.
	private bool isJump;

	private float moveForce = 365f;			// Amount of force added to move the player left and right.
	private float maxSpeed = 5f;				// The fastest the player can travel in the x axis.
	private float jumpForce = 500f;

	// アニメーション状態一覧.
	private enum animationState{
		 Walk
		,Jump
		,Win
		,Lose
	}
	// 現在のアニメーションの状態.
	private animationState nowAnimationState;
	                           
	// アニメーション一覧.
	private enum animationSeries{
		 Walk_1	= 0
		,Walk_2
		,Jump
		,Win
		,Lose
	}


	void Awake(){
		// 計測用時間の初期化.
		time 		= 0.0f;
		// ジャンプ用フラグの初期化.
		isJump		= false;
		// フラグの初期化.
		isGrounded	= false;
		// groundCheckを取得.
		groundCheck	= this.transform.Find( "groundCheck" ); 
	}

	// Use this for initialization
	void Start () {
		// SpriteRendererの取得.
//		spRender	= Player.transform.GetComponentInChildren<SpriteRenderer>();
		spRender	= Player.GetComponent<SpriteRenderer>();
		// 初期のアニメーション状態を"Walk"に設定.
		nowAnimationState	= animationState.Walk;

	}
	
	// Update is called once per frame
	void Update () {
		time	+= Time.deltaTime;

		// 地面判定.
		isGrounded	= Physics2D.Linecast( this.transform.position, groundCheck.position, 1 << LayerMask.NameToLayer( "Ground" ) );
		Debug.Log( isGrounded );
		if( ( Input.GetMouseButtonDown(0) || Input.touchCount > 0 ) && isGrounded )
		{
			isJump	= true;
		}

		// 着地後に歩きの判定に戻る.
		if( nowAnimationState == animationState.Jump && isGrounded && !isJump ){
			nowAnimationState = animationState.Walk;
		}

	}

	void FixedUpdate(){

		// アニメーションの状態が"Walk"の場合.	
		if( nowAnimationState == animationState.Walk && !isJump )
		{
			// 設定時間を越えていたら.
			if( time >= ANIM_CYCLE_TIME )
			{	
				// 計測時間を初期化.
				time = 0.0f;
				// 現在のアニメーションがWalk_1の場合.
				if( animNum	== System.Convert.ToInt32( animationSeries.Walk_1 ) )
				{
					animNum	= System.Convert.ToInt32( animationSeries.Walk_2 );
				}
				// 現在のアニメーションがWalk_2の場合.
				else if( animNum == System.Convert.ToInt32( animationSeries.Walk_2 ) )
				{
					animNum = System.Convert.ToInt32( animationSeries.Walk_1 );
				}
				else
				{
					animNum	= System.Convert.ToInt32( animationSeries.Walk_1 );
				}
				spRender.sprite	= PigSprite[ animNum ];
			}
		}
		// Cache the horizontal input.
		//float h = Input.GetAxis("Horizontal");
		float h = 1;
		
		// The Speed animator parameter is set to the absolute value of the horizontal input.
		//anim.SetFloat("Speed", Mathf.Abs(h));
		
		// If the player is changing direction (h has a different sign to velocity.x) or hasn't reached maxSpeed yet...
		if (h * rigidbody2D.velocity.x < maxSpeed) {
			// ... add a force to the player.
			rigidbody2D.AddForce (Vector2.right * h * moveForce);
		}
		
		// If the player's horizontal velocity is greater than the maxSpeed...
		if (Mathf.Abs (rigidbody2D.velocity.x) > maxSpeed) {
			// ... set the player's velocity to the maxSpeed in the x axis.
			rigidbody2D.velocity = new Vector2 (Mathf.Sign (rigidbody2D.velocity.x) * maxSpeed, rigidbody2D.velocity.y);
		}

		if ( isJump )
		{
			nowAnimationState	= animationState.Jump;
			animNum				= System.Convert.ToInt32( animationSeries.Jump );
			spRender.sprite		= PigSprite[ animNum ];

			rigidbody2D.AddForce( new Vector2( moveForce, jumpForce ) );

			isJump				= false;
		}
	}
}
