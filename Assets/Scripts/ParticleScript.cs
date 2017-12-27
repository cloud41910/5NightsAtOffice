using UnityEngine;
using System.Collections;

public class ParticleScript : MonoBehaviour {

	public ParticleSystem clickEffect;
	[HideInInspector]public bool playEffect;

	void Start(){
		clickEffect.Stop ();	
	}

	void Update(){
		if (playEffect == true) {
			clickEffect.Play ();
			playEffect = false;
		}
	}
}
