using UnityEngine;
using System.Collections;

public class TriggerObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Activates gesture options on collision
	void OnCollisionEnter (Collision col)
	{
		print ("Collision detected");
		GameObject.Find ("MainCamera").GetComponent<CardboardRotate> ().getRotValues = true;
	}

	public void GestureActivate (){
		print ("Gesture activated");
		GameObject.Find ("MainCamera").GetComponent<CardboardRotate> ().getRotValues = true;
	}
}
