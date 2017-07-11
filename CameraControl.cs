using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {


	public Transform target; //variabe which copies the player position
	public float speed; //this is the speed of the camera multiplier (how fast it moves)


	
	// Update is called once per frame
	void Update () {


	// get the cameras position, then as the player moves transform camera position to follow player
		transform.position = Vector3.Lerp (transform.position, new Vector3 (target.transform.position.x, target.transform.position.y +1f, transform.position.z), Time.deltaTime * speed);

	}
}
