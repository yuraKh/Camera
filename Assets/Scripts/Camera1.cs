using UnityEngine;
using System.Collections;

public class Camera1 : MonoBehaviour
{
Camera Cam1 = GameObject.Find("Camera 1").GetComponent<Camera>();
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.position += new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0);
        }
        if (Input.GetMouseButton(1))
        {
            transform.Rotate(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0f);
        }
        if (Input.GetKey(KeyCode.F1))
        {
            Vector4 GGg = new Vector4(Cam1.rect.x, Cam1.rect.y, Cam1.rect.height, Cam1.rect.width);
        /*    float camX = Cam1.rect.x;
            float camY = Cam1.rect.y;
            float camW = Cam1.rect.width;
            float camH = Cam1.rect.height;*/
            Cam1.rect = Vector4.MoveTowards(Vector4())
         
          //  Vector4 camStop = new Vector4(0, 0, 1f, 1f);
        /* GameObject.Find("Camera 1").GetComponent<Camera>().rect*/ 
          
          // GameObject.Find("Camera 1").GetComponent<Camera>().rect.x      
        }
       // Camera.main.rect = 
        
    }
}
