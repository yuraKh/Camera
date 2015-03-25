using UnityEngine;
using System.Collections;

public class Camera1 : MonoBehaviour
{
	Camera cam1, cam2;
	Vector4 camWork, camWork1;
	// Use this for initialization
	void Start()
	{
		camWork = new Vector4(0.82f, 0.23f, 0.15f, 0.33f);
		camWork1 = new Vector4 (0.82f, 0.65f, 0.15f, 0.33f);

		cam1 = GameObject.Find("Camera 1").GetComponent<Camera>();
		cam2 = GameObject.Find("Camera 2").GetComponent<Camera>();
		//print (Cam1.ToString());    
	}
	
	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown (0)) {
			Ray Xray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (Xray, out hit, 100f)) {
				hit.collider.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0f, 0.255f), Random.Range(0f, 0.255f), Random.Range(0f, 0.255f));
				                          
            }
        }

		if (Input.GetMouseButtonDown (1)) {
			Ray Xray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (Xray, out hit, 100f)) {
				Instantiate(hit.collider.transform, hit.normal + hit.transform.position, hit.collider.transform.rotation);

                
            }
        }
        
        if (Input.GetMouseButton (0)) {
			if (Input.GetKey (KeyCode.Keypad1)) {
				transform.position += new Vector3 (Input.GetAxis ("Mouse X"), Input.GetAxis ("Mouse Y"), 0);
			}
			if (Input.GetKey (KeyCode.Keypad2)) {
				cam1.transform.position += new Vector3 (Input.GetAxis ("Mouse X"), Input.GetAxis ("Mouse Y"), 0);
			}
			if (Input.GetKey (KeyCode.Keypad3)) {
				cam2.transform.position += new Vector3 (Input.GetAxis ("Mouse X"), Input.GetAxis ("Mouse Y"), 0);
			}
		}
		if (Input.GetMouseButton(1))
		{
			if (Input.GetKey (KeyCode.Keypad1)) {
				transform.Rotate(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0f);			
			}
			if (Input.GetKey (KeyCode.Keypad2)) {
				cam1.transform.Rotate(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0f);			
			}
			if (Input.GetKey (KeyCode.Keypad3)) {
				cam2.transform.Rotate(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0f);			
			}
		}
		if (Input.GetKeyDown (KeyCode.F1)) {
			if (camWork.x != 0) {            
				camWork = new Vector4 (0, 0, 1f, 1f);
			} else {
				camWork = new Vector4 (0.82f, 0.23f, 0.15f, 0.33f);
			}
		}
		
		Vector4 camStart = new Vector4 (cam1.rect.x, cam1.rect.y, cam1.rect.width, cam1.rect.height);
		Vector4 camStop = Vector4.MoveTowards (camStart, camWork, 0.05f);
		
		cam1.rect = new Rect (camStop.x, camStop.y, camStop.z, camStop.w);
		
		if (Input.GetKeyDown (KeyCode.F2)) {
			if (camWork1.x != 0) {            
				camWork1 = new Vector4 (0, 0, 1f, 1f);
			} else {
				camWork1 = new Vector4 (0.82f, 0.65f, 0.15f, 0.33f);
			}
		}
		
		camStart = new Vector4 (cam2.rect.x, cam2.rect.y, cam2.rect.width, cam2.rect.height);
		camStop = Vector4.MoveTowards (camStart, camWork1, 0.05f);
		
		cam2.rect = new Rect (camStop.x, camStop.y, camStop.z, camStop.w);
    }
}