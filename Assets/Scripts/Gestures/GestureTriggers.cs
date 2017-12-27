using System;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GestureTriggers : MonoBehaviour {
	[HideInInspector]public float yRight;
	[HideInInspector]public float yLeft;
	[HideInInspector]public float currentY;
	[HideInInspector]public float currentX;
	[HideInInspector]public bool triggerActive;
	[HideInInspector]public bool loadNextScene;
	public string nextSceneName = "MainMenu";
	private string sceneName;
	private float detectGesAngle = 7;

	void Start(){
		nextSceneName = SceneManager.GetActiveScene().name;
	}


	void Update(){
		if ((gameObject.GetComponent<CardboardRotate> ().inYes)) {      //will check other |script| if |bool = true|
			//print(currentX);
			if(transform.rotation.eulerAngles.x <= (currentX + detectGesAngle + 15) && transform.rotation.eulerAngles.x >= (currentX + detectGesAngle)){
				print ("X GT: "+ transform.rotation.eulerAngles.x);
			//GameObject.Find("TargetCube").GetComponent<Renderer> ().material.color = Color.green;
			gameObject.GetComponent<CardboardRotate> ().inYes = false;//disables |bool| from other |script| 
			gameObject.GetComponent<CardboardRotate> ().interactYN = false;
				triggerActive = true;
				if (loadNextScene == true)
					SceneManager.LoadScene(nextSceneName);
			}
		}
			
		else if ((!gameObject.GetComponent<CardboardRotate> ().inYes) && (gameObject.GetComponent<CardboardRotate> ().interactYN) && ((gameObject.GetComponent<CardboardRotate> ().inNoLeft_A) || (gameObject.GetComponent<CardboardRotate> ().inNoRight_A) || (gameObject.GetComponent<CardboardRotate> ().inNoLeft_B) || (gameObject.GetComponent<CardboardRotate> ().inNoRight_B))) { //if inYes == false && interactYN == true
			if (gameObject.GetComponent<CardboardRotate> ().inNoLeft_A) { //If cardboard came from the left
				if (transform.rotation.eulerAngles.y <= (yRight + detectGesAngle + 15) && transform.rotation.eulerAngles.y >= (yRight + detectGesAngle)){
					print ("NO (From left_a) Y GT: "+ yLeft);												//do stuff here
					//GameObject.Find("TargetCube").GetComponent<Renderer> ().material.color = Color.red;
					gameObject.GetComponent<CardboardRotate> ().inNoLeft_A = false;
					gameObject.GetComponent<CardboardRotate> ().interactYN = false;
					triggerActive = true;
				}
			} 
			else if (gameObject.GetComponent<CardboardRotate> ().inNoRight_A) { //If cardboard came from the right
				if (transform.rotation.eulerAngles.y >= (yLeft - detectGesAngle - 15) && transform.rotation.eulerAngles.y <= (yLeft - detectGesAngle)){
					print ("NO (From right_a) Y GT: "+ yRight);								 			  //do stuff here
					//GameObject.Find("TargetCube").GetComponent<Renderer> ().material.color = Color.red;
					gameObject.GetComponent<CardboardRotate> ().inNoRight_A = false;
					gameObject.GetComponent<CardboardRotate> ().interactYN = false;
					triggerActive = true;
				}
			}
			else if (gameObject.GetComponent<CardboardRotate> ().inNoLeft_B) { //If cardboard came from the left
				if (transform.rotation.eulerAngles.y <= (yRight + detectGesAngle + 15) && transform.rotation.eulerAngles.y >= (yRight + detectGesAngle)){
					print ("NO (From left_b) Y GT: "+ yLeft);												//do stuff here
					//GameObject.Find("TargetCube").GetComponent<Renderer> ().material.color = Color.red;
					gameObject.GetComponent<CardboardRotate> ().inNoLeft_B = false;
					gameObject.GetComponent<CardboardRotate> ().interactYN = false;
					triggerActive = true;
				}
			} 
			else if (gameObject.GetComponent<CardboardRotate> ().inNoRight_B) { //If cardboard came from the right
				if (transform.rotation.eulerAngles.y >= (yLeft - detectGesAngle - 15) && transform.rotation.eulerAngles.y <= (yLeft - detectGesAngle)){
					print ("NO (From right_b) Y GT: "+ yRight);								 			  //do stuff here
					//GameObject.Find("TargetCube").GetComponent<Renderer> ().material.color = Color.red;
					gameObject.GetComponent<CardboardRotate> ().inNoRight_B = false;
					gameObject.GetComponent<CardboardRotate> ().interactYN = false;
					triggerActive = true;
				}
			}

		}

		else if (gameObject.GetComponent<CardboardRotate> ().inLeft) {     
			print ("LEFT");								 			  //do stuff here
			gameObject.GetComponent<CardboardRotate> ().inLeft = false;
			gameObject.GetComponent<CardboardRotate> ().interactLR = false;
		}

		else if (gameObject.GetComponent<CardboardRotate> ().inRight) {     
			print ("RIGHT");								 			  //do stuff here
			gameObject.GetComponent<CardboardRotate> ().inRight = false;
			gameObject.GetComponent<CardboardRotate> ().interactLR = false;
		}

	}


}
