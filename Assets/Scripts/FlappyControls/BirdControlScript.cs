using UnityEngine;
using System.Collections;

public class BirdControlScript : MonoBehaviour {
	private bool jump;
	private BirdCharacter2D character;
	private int move;

	// Use this for initialization
	void Start () {
		character = GetComponent<BirdCharacter2D> ();
		move = 1;
	}
	
	// Update is called once per frame
	void Update ()
	{
		// Read the jump input in Update so button presses aren't missed.
		
		if (CrossPlatformInput.GetButtonDown("Jump")) { 
				jump = true;
				Debug.Log("Jump");
		}
		if(Input.touchCount > 0)
		{ 
			if(Input.GetTouch(0).phase == TouchPhase.Began)
			{
					jump = true;
					Debug.Log("Jump2");

			}
		}
		
		
	}
	void FixedUpdate()
	{
		
		// Pass all parameters to the character control script.
		character.Move( move, false , jump );
		
		// Reset the jump input once it has been used.
		jump = false;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		move = 1;
	}
}