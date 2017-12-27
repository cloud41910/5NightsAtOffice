using UnityEngine;
using System.Collections;

public class Airplane : MonoBehaviour {



	public int Speed = 10;

	// Use this for initialization
	void Start () {
	}

	void OnCollisionEnter (Collision col){
		if(col.gameObject.tag == "Finish")
		{
			print (col.gameObject.name);
		}
	}

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * Time.deltaTime * Speed);
		//rigidbody.velocity = Vector3(0,10,0);
		//float step = speed * Time.deltaTime;
		//transform.position = Vector3.MoveTowards(transform.position, EndPoints[Random.Range(0,EndPoints.Length)].position, step);
	}
}
