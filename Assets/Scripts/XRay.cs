using UnityEngine;
using System.Collections;

public class XRay : MonoBehaviour {

	public Color startCol;

	// Use this for initialization
	void Start () {
		startCol = transform.GetComponent<MeshRenderer>().material.color;
	}
	
	// Update is called once per frame
	void Update () {
		transform.GetComponent<MeshRenderer> ().material.color = Color.Lerp (transform.GetComponent<MeshRenderer> ().material.color, startCol, 0.01f);
	}
}
