using UnityEngine;
using System.Collections;

public class invisible : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Renderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	//if not, replace with (Collision collision)
	void OnCollisionEnter(Collision collision){
		//Destroy (collision.collider.gameObject);
		//Destroy (collision.gameObject);
	}
}
