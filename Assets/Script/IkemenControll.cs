using UnityEngine;
using System.Collections;

public class IkemenControll : MonoBehaviour
{	
	public SpriteRenderer[] Ikemen1;
	public SpriteRenderer[] Ikemen2;
	public int imgSize = 3;

	private float _delTime = 5;

	void Awake ()
	{
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag == "Ikemen") {

			int _charaNum = 0;

			if (col.gameObject.name == "ikemen1") {
				_charaNum = 1;
			} else if (col.gameObject.name == "ikemen2") {
				_charaNum = 2;
			}

			this.UpdateIkemenMsg(_charaNum);

			Destroy(col.gameObject);
		}
	}

	public void UpdateIkemenMsg(int charaNum)
	{
		SpriteRenderer img = null;
		Vector3 imgPos;
		GameObject parent;
		
		parent = GameObject.Find("mainCamera");
		imgPos = new Vector3 (11, 4, 0);

		switch (charaNum) {
			case 1:
				img = (SpriteRenderer)Instantiate(Ikemen1[Random.Range(0, imgSize)], imgPos, parent.transform.rotation);
				img.sortingLayerName = "Foreground";
				img.sortingOrder = 1;
				img.transform.parent = parent.transform;
				img.name = "IkemenMsg" + charaNum;
				break;
			case 2:
				img = (SpriteRenderer)Instantiate(Ikemen2[Random.Range(0, imgSize)], imgPos, this.transform.rotation);
				break;
			default:
				break;
		}
		
		if (img != null) {
			Destroy(img, _delTime);
		}
	}
}
