using UnityEngine;
using System.Collections;


public class CardboardRotate : MonoBehaviour {

    public bool getRotValues = false;
	[HideInInspector]public bool interactYN;
	[HideInInspector]public bool inYes = false;
	//public bool inNo = false;
	[HideInInspector]public bool inNoLeft_A = false;
	[HideInInspector]public bool inNoRight_A = false;
	[HideInInspector]public bool inNoLeft_B = false;
	[HideInInspector]public bool inNoRight_B = false;
	[HideInInspector]public bool interactLR = false;
	[HideInInspector]public bool inLeft = false;
	[HideInInspector]public bool inRight = false;
	private float detectGesAngle = 7;
	private float currentY;
	private float currentX;
	private float yRight, yLeft;

	void Start(){
		currentY = GameObject.Find ("MainCamera").transform.rotation.eulerAngles.y; //gets current rotation of camera in y
		currentX = GameObject.Find ("MainCamera").transform.rotation.eulerAngles.x; //gets current rotation of camera in x
		print("Init X: "+ currentX +" / Y: " +currentY);
	}

	void Update () {
		
		if (getRotValues == true){ //UIFader line 151-152
			currentY = GameObject.Find ("MainCamera").transform.rotation.eulerAngles.y;
			currentX = GameObject.Find ("MainCamera").transform.rotation.eulerAngles.x;
			print("getRotValues X: "+ currentX +" / Y: " +currentY);
			interactYN = true;
				
			if((currentX >= (360 - detectGesAngle) && currentX < 360)||(currentX >= (0) && currentX <= (0 + detectGesAngle - 2)))
				currentX = 360 - detectGesAngle - 1 ;
			GameObject.Find ("MainCamera").GetComponent<GestureTriggers> ().currentX = currentX;
			print("0 X: "+ currentX +" / Y: " +currentY);
			getRotValues = false;
		}
		if (interactYN == true) {  //for Yes/No inbetween (360 - detectGesAngle) & (detectGesAngle) 
			if (inYes == false && (((currentY >= (360 - detectGesAngle)) && (currentY < 360)) || ((currentY >= 0) && (currentY <= 0 + detectGesAngle)))) { //if within (360 - detectGesAngle) & (detectGesAngle) 
				if ((currentY >= (360 - detectGesAngle)) && (currentY < 360)) { //if currentY is within (360 - detectGesAngle) and 360 (LEFT)

					if(currentY + detectGesAngle >= 360)
						GameObject.Find ("MainCamera").GetComponent<GestureTriggers> ().yRight = (currentY + detectGesAngle) - 360; //Will detect Right trigger
					
					if (inNoRight_A == false && (transform.rotation.eulerAngles.y <= (currentY - detectGesAngle)) && (transform.rotation.eulerAngles.y >= (currentY - detectGesAngle -15))){ //if it hits Left triggers
						print ("inNoLeft A: " + (transform.rotation.eulerAngles.y));
						inNoLeft_A = true;
					} 
				}

				else if ((currentY >= 0) && (currentY <= 0 + detectGesAngle)){

					if((currentY -detectGesAngle) < 0)
						GameObject.Find ("MainCamera").GetComponent<GestureTriggers> ().yLeft = (currentY - detectGesAngle) + 360; //Will detect Left trigger

					if (inNoLeft_A == false && (transform.rotation.eulerAngles.y >= (currentY + detectGesAngle)) && (transform.rotation.eulerAngles.y <= currentY + detectGesAngle + 15)) {
						print ("inNoRight A: " + (transform.rotation.eulerAngles.y));	
						inNoRight_A = true;
					}
				}
			}

			else
			{
				if (inYes == false && inNoRight_B == false && (transform.rotation.eulerAngles.y >= (currentY - detectGesAngle - 15) && transform.rotation.eulerAngles.y <= (currentY - detectGesAngle))) { //Detects if camera rotates N degrees in Y
					if (inNoLeft_B == false)
						print ("NoLeft B: "+ transform.rotation.eulerAngles.y); //prints current Y angle in console
					GameObject.Find ("MainCamera").GetComponent<GestureTriggers> ().yRight = currentY;
					inNoLeft_B = true; 							  
				} 
				else if (inYes == false && inNoLeft_B == false && (transform.rotation.eulerAngles.y <= (currentY + detectGesAngle +15) && transform.rotation.eulerAngles.y >= (currentY + detectGesAngle))) {//Detects if camera rotates N degrees to the right
					if (inNoRight_B == false)
						print ("NoRight B: "+ transform.rotation.eulerAngles.y); //prints current Y angle in console
					GameObject.Find ("MainCamera").GetComponent<GestureTriggers> ().yLeft = currentY;
					inNoRight_B = true;
					}
			}
			//YES GESTURE
			if (((inNoLeft_A == false || inNoRight_A == false)||(inNoLeft_B == false || inNoRight_B == false)||(inNoLeft_B == false && inNoRight_B == false)) && (transform.rotation.eulerAngles.x >= (currentX - detectGesAngle - 15) && transform.rotation.eulerAngles.x <= (currentX - detectGesAngle))) {//Detects if camera rotates N degrees in X
				if (inYes == false)
					print ("X YES : " + transform.rotation.eulerAngles.x); //prints current X angle in console
				inYes = true;
				}
				//getRotValues = true;
		}
		if (interactLR == true) {  //for Left/Right
			if (inLeft == false && (transform.rotation.eulerAngles.y <= (currentY + detectGesAngle +15) && transform.rotation.eulerAngles.y >= (currentY+detectGesAngle))) { //Detects if camera rotates N degrees to the left
						print (transform.rotation.eulerAngles.y); //prints current Y angle in console
				GameObject.Find ("MainCamera").GetComponent<GestureTriggers> ().yRight = currentY;	
				inRight = true; 							  
				} 
				else if (inRight == false && (transform.rotation.eulerAngles.y >= (currentY - detectGesAngle - 15) && transform.rotation.eulerAngles.y <= (currentY - detectGesAngle))) {//Detects if camera rotates N degrees to the right
						print (transform.rotation.eulerAngles.y); //prints current X angle in console
				GameObject.Find ("MainCamera").GetComponent<GestureTriggers> ().yLeft = currentY;	
				inLeft = true;
					}
					//getRotValues = true;
			}
	}


}	


