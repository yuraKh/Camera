using UnityEngine;
using System.Collections;

public class EarthMove : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		GameObject.Find("Cube1").transform.Rotate(0f, 0f, 0.5f);
		GameObject.Find("Capsule").transform.Rotate(0f, 0.3f, 0.5f);
		GameObject.Find("Cube").transform.Rotate(0.1f, 0.3f, 0.5f);
        GameObject.Find("Moon").transform.Rotate(0, 0.3f, 0);
        GameObject.Find("Earth").transform.Rotate(0, -0.1f, 0);
        transform.RotateAround(Vector3.zero, Vector3.up, 50 * Time.deltaTime);
		GameObject.Find ("Cube").transform.RotateAround (Vector3.zero, Vector3.left, 1f);
		GameObject.Find ("Capsule").transform.RotateAround (transform.position, Vector3.back, 1f);
		GameObject.Find("Cube1").transform.RotateAround(Vector3.zero, Vector3.forward, 50 * Time.deltaTime);
    }
}
