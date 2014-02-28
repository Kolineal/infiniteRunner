using UnityEngine;
using System.Collections;

public class FlappyHUDScript : MonoBehaviour {
	public GUIStyle RetryButtonStyle;
	public GUIStyle labelStyle;

	public GameObject player;

	SpawnScript tubeSpawn;
	// Use this for initialization
	/* 
	void Start () {
		tubeSpawn = GameObject.Find("Spawner"). GetComponent<SpawnScript> ();
		tubeSpawn.enabled = false;
	}
	 */
	void Awake(){
		tubeSpawn = GameObject.Find("Spawner"). GetComponent<SpawnScript> ();
		tubeSpawn.enabled = false;
	}
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI()
	{
		GUI.Label (new Rect (Screen.width/2 - 50, Screen.height/2 + 32, 100,30),"Tap anywhere to fly", labelStyle);
		if (GUI.Button (new Rect (Screen.width / 2 - 32, Screen.height / 2 - 16, 64, 32), "", RetryButtonStyle)) 
		{
			tubeSpawn.enabled = true;
			player.rigidbody2D.gravityScale = 1;
			//tubeSpawn.Spawn();
			enabled = false;
		}

						
	}
}
