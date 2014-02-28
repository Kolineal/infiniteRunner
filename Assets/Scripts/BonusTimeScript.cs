using UnityEngine;
using System.Collections;

public class BonusTimeScript : MonoBehaviour {
	public GameObject HUDCamera;
	public float bonusValue = 200; 
	void OnTriggerEnter2D(Collider2D other)
	{
		HUDCamera = GameObject.FindGameObjectWithTag ("MainCamera");
		if (other.tag == "Player")
		{
			HUDScript HUD = HUDCamera.GetComponent<HUDScript>();
			HUD.inscreaseScore(bonusValue);
			Destroy(this.gameObject);
		}
		
	}
}
