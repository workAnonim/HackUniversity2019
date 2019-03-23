using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomHandler : MonoBehaviour {
	float distance;
	public Transform Target;
	public float speedRotateX = 5;
	public float speedRotateY = 5;
	bool istouch = false;

	void Update () {
		//if(Input.
		if (Input.GetKeyDown (KeyCode.Mouse0)) {   // если отжата N
			Debug.Log("sdd1");
			istouch = true;
		}
		if (Input.GetKeyUp (KeyCode.Mouse0)) {   // если отжата N
			Debug.Log("sdd");
			istouch = false;
		}

		if (Input.touchCount == 2) {
			Zoom ();
		} else {
			if (distance != 0) {
				distance = 0;
			}
			if (Input.GetMouseButton(0)){/*Input.touchCount == 1) {*/
				Swipe();
			}
		}
		


	}
	void Swipe(){
		/*Vector2 delta = Input.GetTouch (0).deltaPosition;

		if (Mathf.Abs (delta.x) > Mathf.Abs (delta.y)) {
			if (delta.x > 0) {
			} else {
				//Debug.Log ();
			}
		}/* else {
			if (delta.y > 0) {
			} else {
			}
		}*/
		float rotX = Input.GetAxis("Mouse X") * speedRotateX * Mathf.Deg2Rad;
		float rotY = Input.GetAxis("Mouse Y") * speedRotateY * Mathf.Deg2Rad;

		if (Mathf.Abs(rotX) > Mathf.Abs(rotY))
			Target.RotateAroundLocal(Target.up, -rotX);
		else
		{
			var prev = Target.rotation;
			Target.RotateAround(Camera.main.transform.right, rotY);
			if (Vector3.Dot(Target.up, Camera.main.transform.up) < 0.5f)
				Target.rotation = prev;
		}
	}
	void Zoom(){
		Vector2 finger1 = Input.GetTouch (0).position;
		Vector2 finger2 = Input.GetTouch (1).position;

		if (distance == 0) {
			distance = Vector2.Distance (finger1, finger2);
		}
		float delta = Vector2.Distance (finger1, finger2) - distance;

		transform.position = Vector3.MoveTowards (transform.position, transform.position + transform.forward, delta*Time.deltaTime);
		//Debug.Log (Vector3.MoveTowards (transform.position, transform.position + transform.forward, delta*Time.deltaTime).ToString());

		distance = Vector2.Distance (finger1, finger2);
	}
}
