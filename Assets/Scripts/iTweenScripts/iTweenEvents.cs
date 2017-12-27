using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class iTweenEvents : MonoBehaviour {

	[SerializeField] private TagHolder holdTag;
	public GameObject TweenObject; 
	private bool selectionComplete;

	void Start(){
		//objPosY = gameObject.transform.position.y;
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Bullet") {

			print("Pew");
			Destroy (col.gameObject);
		}
	}

	public void GetObj(){
		holdTag.gameObj = TweenObject;
		holdTag.GetGameObj (); //Calls GetGameObj() at MainCamera
		TweenObject = holdTag.curGameObj;

		//print ("TweenObj: "+ TweenObject);
	}
}
