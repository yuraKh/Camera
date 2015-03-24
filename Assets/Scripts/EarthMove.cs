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
        GameObject.Find("Moon").transform.Rotate(0, 0.3f, 0);
        GameObject.Find("Earth").transform.Rotate(0, -0.1f, 0);
        transform.RotateAround(Vector3.zero, Vector3.up, 50 * Time.deltaTime);
        //transform.Rotate(Vector3.right * Time.deltaTime);
    }
}
