using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	private GameObject ball;
	Transform cameraTransform;
	Transform ballTransform;

	public void init(GameObject ball) {
		this.ball = ball;
		ballTransform = this.ball.GetComponent<Transform> ();

		cameraTransform = GetComponent<Transform> ();
		Vector3 ballPos = ballTransform.position;
		cameraTransform.position = new Vector3(ballPos.x, ballPos.y+20, ballPos.z);
		cameraTransform.rotation = Quaternion.Euler (90.0f, 0.0f, 0.0f);
		Camera camera = GetComponent<Camera> ();
		camera.orthographic = true;
		camera.orthographicSize = 15.0f;
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 ballPos = ballTransform.position;
		cameraTransform.position = new Vector3(ballPos.x, ballPos.y+20, ballPos.z);		
	}
}
