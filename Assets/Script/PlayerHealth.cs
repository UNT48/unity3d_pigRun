using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{	
	public float health = 3f;
	public AudioClip[] ouchClips;
	public float damageAmount = 1f;
	public SpriteRenderer healthImage;
	public SpriteRenderer healthNoImage;

	public AudioClip damageClip;

	private float _curHealth = 0;
	private int _curScore = 0;
	private SpriteRenderer[] _healthImgs;

	void Awake ()
	{
		_curHealth = this.health;
		_healthImgs = new SpriteRenderer[(int)this.health];
	
		this.CreateHealthBar ();
	}

	void FixedUpdate()
	{
		_curScore += 1;
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag == "Enemy") {
			TakeDamage (col.gameObject, 1, 0);
		} else if (col.gameObject.tag == "Dumbbell") {
			TakeScore (col.gameObject, 1, 100);
		}
	}
	
	void TakeDamage (GameObject go, int helath, int score)
	{
		gameObject.audio.clip = this.damageClip;
		gameObject.audio.Play();

		if (_curHealth > 0) {
			_curHealth -= helath;
			_curScore -= score;
		}
		//  judge GameOver.
		if(_curHealth == 0) {
			score = GetScore() / 100;
			PlayerPrefs.SetInt ("score",score);
			Application.LoadLevel("GameOver");
		}

		UpdateHealthBar ();
		Destroy (go);
	}

	void TakeScore (GameObject go, int health, int score)
	{
		if (_curHealth < 3) {
			_curHealth += health;
		}

		_curScore += score;

		UpdateHealthBar ();
		Destroy (go);
	}
	 
	public void CreateHealthBar ()
	{
		SpriteRenderer life;
		SpriteRenderer noLife;
		Vector3 imgPos;
		GameObject parent;

		parent = GameObject.Find("mainCamera");
		
		for (int i = 0; i < this.health; i++) {
			imgPos = new Vector3(-32 + (3*i), 6, 0);
		
			life = (SpriteRenderer)Instantiate(healthImage, imgPos, this.transform.rotation);
			life.sortingLayerName = "Foreground";
			life.sortingOrder = 2;
			life.transform.parent = parent.transform;
			life.name = "healthImg_" + i;

			noLife = (SpriteRenderer)Instantiate(healthNoImage, imgPos, this.transform.rotation);
			noLife.sortingLayerName = "Foreground";
			noLife.sortingOrder = 1;
			noLife.transform.parent = parent.transform;
			noLife.name = "healthNoImg_" + i;

			_healthImgs[i] = life;
		}
	}

	public void UpdateHealthBar ()
	{
		for (int i = 0; i < this.health; i++) {
			if (i < _curHealth) {
				_healthImgs[i].enabled = true;
			}
			else {
				_healthImgs[i].enabled = false;
			}
		}
	}

	public int GetScore ()
	{
		return this._curScore;
	}
}
