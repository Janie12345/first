using UnityEngine;
using System.Collections;

public class roll : MonoBehaviour {

	public float speed;
	public float UpDownSpeed;

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal"); 
		float moveVertical = Input.GetAxis ("Vertical");
		//float moveUpDown = 0f;

		if (Input.GetKey(KeyCode.R)){
			transform.position = new Vector3 (277.5f, 30, 253.7205f);
		}
		//moveUpDown = 1.0f;
		//print ("space pressed");
		//}

		// print(moveVertical);

		//Vector3 movement = new Vector3 (moveHorizontal, moveUpDown*UpDownSpeed, moveVertical);
		Vector3 movement = new Vector3 (moveHorizontal,UpDownSpeed, moveVertical);

		rb.AddForce (movement * speed);


	}

	//void OnTriggerEnter(Collision other)
	//{
		//if (other.gameObject.CompareTag("invisible")) {
		//if (Input.GetKey("KeyCode.w")) {
			//transform.position = new Vector3 (277.5f, 30, 253.7205f);
		//}
	//}

}
	
