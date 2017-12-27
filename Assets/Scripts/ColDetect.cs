using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColDetect : MonoBehaviour {

	int a;

	void OnCollisionEnter (Collision col){
		if(col.gameObject.tag == "Finish")
		{
			print (a);
			a++;
		}
	}
}
