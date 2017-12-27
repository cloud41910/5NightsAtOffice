using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastScript : MonoBehaviour {

	public GameObject cube;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) //Click to fire Raycast
			Raycast1 ();
	}

	void Raycast1 (){

		//Raycast from camera to mouse pointer

		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit, Mathf.Infinity)) {
				Debug.Log (hit.collider.gameObject.name);
			} 
			else {
				Debug.Log ("Not Hit");	
			}
	}

	void Raycast2(){

		//Fires a Raycast from the z axis (Vector3.forward) of the GameObject

		if (Physics.Raycast (cube.transform.position, Vector3.forward, Mathf.Infinity)) {
			Debug.Log ("Hit");
		} else
			Debug.Log ("Not Hit 2");
	}
}
