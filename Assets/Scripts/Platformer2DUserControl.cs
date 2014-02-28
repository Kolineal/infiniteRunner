using UnityEngine;

[RequireComponent(typeof(PlatformerCharacter2D))]
public class Platformer2DUserControl : MonoBehaviour 
{
	private PlatformerCharacter2D character;
    private bool jump;


	void Awake()
	{
		character = GetComponent<PlatformerCharacter2D>();
	}

    void Update ()
    {
        // Read the jump input in Update so button presses aren't missed.

		if (CrossPlatformInput.GetButtonDown("Jump")) { 
			if(character.pause)
				character.pause = false;
			else
				jump = true;
		}
		if(Input.touchCount > 0)
		{ 
			if(Input.GetTouch(0).phase == TouchPhase.Began)
			{
				if(character.pause)
					character.pause = false;
				else
					jump = true;

			}
		}


    }

	void FixedUpdate()
	{
		// Read the inputs.
		bool crouch = Input.GetKey(KeyCode.LeftControl);
		#if CROSS_PLATFORM_INPUT
		float h = CrossPlatformInput.GetAxis("Horizontal");
		#else
		float h = Input.GetAxis("Horizontal");
		#endif

		// Pass all parameters to the character control script.
		character.Move( 1, false , jump );

        // Reset the jump input once it has been used.
	    jump = false;
	}
}
