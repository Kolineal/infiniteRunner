using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {
	public GUIStyle labelStyle;
	public Texture2D heartIcon;
	public GameObject player;

	float playerScore = 0;
	void Start()
	{
		labelStyle.normal.textColor = Color.red;
	}

	// Update is called once per frame
	void Update () {
		SpawnScript t = GameObject.Find("PortalSpawningCapsule").GetComponent<SpawnScript>();
		if (playerScore > 6000)
		{
			Debug.Log(t);
			t.enabled = true;
		}
		playerScore += Time.deltaTime * 100;
	}
	public void inscreaseScore(float bonus)
	{
		playerScore += bonus;
	}
	void OnGUI()
	{
		GUI.Label (new Rect (10,10, 100, 30), "Score: " + (int)playerScore,labelStyle);
		GUI.Label (new Rect (10, 40, 35, 35), heartIcon);
		GUI.Label (new Rect (40,45,100,30), "" + player.GetComponent<PlatformerCharacter2D>().lifes,labelStyle);
		          


	}
	public void OnDisable()
	{
		PlayerPrefs.SetInt ("Score", (int)playerScore);
	}
}
