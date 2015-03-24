using UnityEngine;
using System.Collections;

public class Camera1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetMouseButton(0)) {
			transform.position += new Vector3 (Input.GetAxis ("Mouse X"), Input.GetAxis ("Mouse Y"), 0);
		}
		if (Input.GetMouseButton(1)) {
			//transform.rotation = new Quaternion(Input.GetAxis ("Mouse X"), 0, 0, 0);
			transform.Rotate(Input.GetAxis ("Mouse Y"),Input.GetAxis ("Mouse X"),0f);
		}
		if (Input.GetKey(KeyCode.F1)) {

			//GameObject.Find("Camera 1").GetComponent<Camera>().rect
			GameObject.Find("Camera 2").transform.position -= new Vector3(0.01f, 0, 0);
		}
		//Camera.main.rect.
		//Vector4.t
	}
}
