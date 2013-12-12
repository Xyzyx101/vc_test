using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {
	public Vector3 spin = new Vector3(200.0f, 200.0f, 200.0f);

	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate () {
		Quaternion deltaRotation = Quaternion.Euler(spin * Time.fixedDeltaTime);
		//Quaternion deltaRotation = Quaternion.Euler(eulerAngleVelocity * Time.deltaTime);
		rigidbody.MoveRotation(rigidbody.rotation * deltaRotation);
	}
}
