using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class MoveAtLook : MonoBehaviour {

	void Start(){
		
	}
	public void MoveObjUp(){
		iTween.MoveTo(gameObject,iTween.Hash("y",3,"time",4));
	}
}
