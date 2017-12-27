using UnityEngine;
using System.Collections;

public class TimedGaze : MonoBehaviour {

	public bool gazeCheck = false;
	public bool gazeTimeComplete = false;
	public float stareTime = 3;

	//gameObject.GetComponent<CardboardRotate> ().inYes
	//(!GameObject.Find ("MainCamera").GetComponent<CardboardRotate> ().interactYN) || (!GameObject.Find ("MainCamera").GetComponent<CardboardRotate> ().interactLR

	public void gazeIn(){
		gazeCheck = true;
		print ("1");
		if ((!GameObject.Find ("MainCamera").GetComponent<CardboardRotate> ().interactYN)) {
			print ("2");
			StartCoroutine (targetActive ());
		}
	}

	public void gazeOut(){
		gazeCheck = false;
	}

	IEnumerator targetActive () {
		print ("WAIT LANG " + Time.time);
			yield return new WaitForSeconds (stareTime);
		if (gazeCheck == true) {
			print ("ACTIVATED " + Time.time);
			gameObject.GetComponent<Renderer> ().material.color = Color.black;
			gazeTimeComplete = true;
			GameObject.Find ("MainCamera").GetComponent<CardboardRotate> ().interactYN = true;
		} 
		else
			print ("PLEASE STARE AT THE TARGET FOR " + stareTime + " SECONDS");
	}
}
