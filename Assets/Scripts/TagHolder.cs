using UnityEngine;
using System.Collections;

public class TagHolder : MonoBehaviour {


	[HideInInspector] public GameObject gameObj;
	[HideInInspector] public GameObject curGameObj;
	[HideInInspector] public bool selectComplete;
	private bool getObj;


	void Start(){
		getObj = true;
	}

	void Update(){
		if (selectComplete == true) {
			print ("ABC: " + curGameObj);
			TweenEvents ();
			selectComplete = false;
			
		}
	}

	public void GetGameObj(){ //Gets the target GameObject
		if (getObj == true && curGameObj !=gameObj) {
			curGameObj = gameObj;
			getObj = false;
		} 
		else if (getObj == false && curGameObj != gameObj) {
			curGameObj = gameObj;
			getObj = true;
		}
	}

	public void TweenEvents(){
		print ("WTF : "+curGameObj);
		if (curGameObj.name == "Drawer1" || curGameObj.name == "Drawer2") {
			print ("DRAWER");
				curGameObj.GetComponent<DrawerTween> ().OpenCloseDrawer ();
		} 
		else if (curGameObj.name == "Notice") {
			print ("MESSAGE");
			curGameObj.GetComponent<NoticeTween> ().MessageDisplay ();
		}
		else if (curGameObj.name == "MugMsg") {
			print ("MESSAGE");
			curGameObj.GetComponent<MugTween> ().MessageDisplay ();
		}
	}
}
