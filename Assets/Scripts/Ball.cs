using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	private Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown() {
		rigidbody.AddForce (new Vector3(10.0f, 0.0f, 0.0f), ForceMode.Impulse);
	}

	void OnCollisionEnter(Collision col) {
		Debug.Log ("trigger 3d");
	}

	void OnCollisionEnter2D(Collision2D col2d) {
		Debug.Log ("trigger 2d");
	}
}
