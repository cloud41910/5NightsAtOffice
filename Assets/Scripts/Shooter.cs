using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Shooter : MonoBehaviour {

	public GameObject Bullet; 
	public Transform BulletSpawn;
	//public AudioClip shootsound;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			Instantiate (Bullet, BulletSpawn.transform.position, BulletSpawn.transform.rotation);
			//AudioSource.PlayClipAtPoint (shootsound, transform.position);
		}
	}
}
