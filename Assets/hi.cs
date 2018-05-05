using UnityEngine;
using System.Collections;

public class hi : MonoBehaviour {
	
	public float speed;
	public float UpDownSpeed;


	private bool canJump = false;
	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void Update ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal"); 
		float moveVertical = Input.GetAxis ("Vertical");
		float moveUpDown = 0f;



		// print(moveVertical);
		if (canJump) {
			if (Input.GetKeyDown("space")) {
				moveUpDown = 1.0f;
				print ("space pressed");
			}
		}
		Vector3 movement = new Vector3 (moveHorizontal, moveUpDown*UpDownSpeed, moveVertical);
		//Vector3 movement = new Vector3 (moveHorizontal,UpDownSpeed, moveVertical);

		rb.AddForce (movement * speed);



	}

	void OnCollisionEnter(Collision collision){

		canJump = true;

	}

	void OnCollisionExit(Collision collision){
		canJump = false;
	}
}

