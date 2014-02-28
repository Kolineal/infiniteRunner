using UnityEngine;
using System.Collections;

public class BirdCharacter2D : MonoBehaviour {

	public float speed = 3f;
	// For determining which way the player is currently facing.
	
	[SerializeField] float maxSpeed = 10f;				// The fastest the player can travel in the x axis.
	[SerializeField] float jumpForce = 400f;	// Amount of force added when the player jumps.	

	int score = 0;
	Animator anim;		
	void Start(){
		rigidbody2D.gravityScale = 0;
	}
	
	void Awake()
	{
		// Setting up references.

		anim = GetComponent<Animator>();
	}
	
	
	void FixedUpdate()
	{
		// The player is grounded if a circlecast to the groundcheck position hits anything designated as ground

		//anim.SetInteger("playerState", 1);
		
		// Set the vertical animation
		anim.SetFloat("vSpeed", rigidbody2D.velocity.y);

	}
	
	
	public void Move(float move, bool crouch, bool jump)
	{
		rigidbody2D.velocity = new Vector2(speed, rigidbody2D.velocity.y);


	
		if (jump && rigidbody2D.gravityScale != 0) {
			Debug.Log("Jump3");

			// Add a vertical force to the player.
			//anim.SetInteger("playerState", 3);
			rigidbody2D.velocity = new Vector3(rigidbody2D.velocity.x, 0); 
			rigidbody2D.AddForce(new Vector2(0f, jumpForce));
		}
		
	
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		score++;
		Debug.Log ("Score: " + score);
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		Application.LoadLevel (1);

	}

}
