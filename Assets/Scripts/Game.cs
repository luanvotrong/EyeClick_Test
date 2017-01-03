using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
	public GameObject mainCamera;
	public GameObject prefabBall;

	private GameObject ball;
	private Camera camera;

	// Use this for initialization
	void Start () {
		ball = Instantiate (prefabBall);

		Transform transformCamera = mainCamera.GetComponent<Transform> ();
		Vector3 ballPos = ball.transform.position;
		transformCamera.position = new Vector3(ballPos.x, ballPos.y+20, ballPos.z);
		transformCamera.rotation = Quaternion.Euler (90.0f, 0.0f, 0.0f);
		camera = mainCamera.GetComponent<Camera> ();
		camera.orthographic = true;
		camera.orthographicSize = 10.0f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown() {
		Debug.Log ("fdsafsfd");
	}
}
