using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	
	public int Speed = 5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Translate (Vector3.forward * Time.deltaTime * Speed);

		if (gameObject.name == "Bullet(Clone)") {

			Destroy (this.gameObject, 2.5f);
		}

	}
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Finish") {
			
			print("Pew");
			Destroy (this.gameObject);
		}
	}
}
