using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{
	public int score = 0;
	private PlayerHealth _playerHealth;
	
	void Awake ()
	{
		_playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
	}
	
	void Update ()
	{
		score = _playerHealth.GetScore();
		guiText.text = "Score: " + score;
	}
}
