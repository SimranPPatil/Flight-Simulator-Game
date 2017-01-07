using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
    public GameObject plane;

    private Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = transform.position - plane.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = plane.transform.position + offset;
	}
}
