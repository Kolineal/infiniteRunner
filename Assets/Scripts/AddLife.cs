using UnityEngine;
using System.Collections;

public class AddLife : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			PlatformerCharacter2D t;
			t = other.GetComponent<PlatformerCharacter2D>();
			t.changeLifesCount(1);
			Destroy(this.gameObject);
		}

	}

}
