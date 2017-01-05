using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
	public GameObject mainCamera;
	public GameObject prefabBall;

	private GameObject ball;
	Transform ballTransform;

	// Use this for initialization
	void Start () {
		ball = Instantiate (prefabBall);
		mainCamera.GetComponent<CameraFollow> ().init (ball);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnMouseDown() {
		Debug.Log ("fdsafsfd");
	}
}
