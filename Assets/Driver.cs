using UnityEngine;
using System.Collections;

public class Driver : MonoBehaviour {

	public float velocity = 0.02f;
	private Vector3 direction = Vector3.forward;

	static Quaternion rotationLeft  = Quaternion.Euler(0, -5, 0);
	static Quaternion rotationRight = Quaternion.Euler(0, 5, 0);

	void Update() {
		if (Input.GetButton("Left")) {
			direction = rotationLeft * direction;
		}
		if (Input.GetButton("Right")) {
			direction = rotationRight * direction;
		}
        transform.position += velocity * direction;
	}
}
