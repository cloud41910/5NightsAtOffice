using UnityEngine;
using System.Collections;

public class DrawerTween : MonoBehaviour {

	private bool close;

	void Start(){
		//objPosY = gameObject.transform.position.y;
		close = true;
	}

	public void OpenCloseDrawer(){
		if (close == true) {
			iTween.MoveBy (gameObject, iTween.Hash ("y", -1, "time", 1.5));
			close = false;
		} 
		else if (close == false) {
			iTween.MoveBy (gameObject, iTween.Hash ("y", 1, "time", 1.5));
			close = true;
		}
	}

}
