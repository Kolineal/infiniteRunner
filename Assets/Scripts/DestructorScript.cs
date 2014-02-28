using UnityEngine;
using System.Collections;

public class DestructorScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
	
		if(other.tag == "Player"){
			PlatformerCharacter2D player = other.GetComponent<PlatformerCharacter2D>();
			player.changeLifesCount(-1);
			return;
		}
		if(other.gameObject.transform.parent){
			Destroy(other.gameObject.transform.parent.gameObject);
		}
		else{
			Destroy(other.gameObject);
		}
	}
}

