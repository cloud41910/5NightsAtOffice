using UnityEngine;
using System.Collections;

public class MugTween : MonoBehaviour {

	[SerializeField] private ParticleScript prtcleEff;
	private bool displayMsg;

	public void MessageDisplay(){
		float objSclX = gameObject.transform.localScale.x;
		print (objSclX);
		if (displayMsg == false) {
			iTween.MoveBy (gameObject, iTween.Hash ("y", 0.16, "time", 1));
			displayMsg = true;
			if (prtcleEff != null)
				prtcleEff.playEffect = true;
		} 
		else {
			iTween.MoveBy (gameObject, iTween.Hash ("y", -0.16, "time", 1));
			displayMsg = false;
		}
	}
}
