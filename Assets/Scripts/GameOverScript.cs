using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	int score = 0;
	public GUIStyle labelStyle;
	public GUIStyle buttonStyle;
	public Texture2D border;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		score = PlayerPrefs.GetInt("Score");
	}
	void OnGUI()
	{
		buttonStyle.normal.background = border;
		GUI.Label (new Rect (Screen.width/2 - 50, 50, 100, 30), "GAME OVER",labelStyle);
		GUI.Label (new Rect (Screen.width/2 - 50, 100, 100,30), "Score: " + score,labelStyle);
		if(GUI.Button (new Rect (Screen.width/2 - 50, 200, 100, 100), "Retry?", buttonStyle))
		{
			Application.LoadLevel(0);
		}
	}
}
