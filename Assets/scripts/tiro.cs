using UnityEngine;
using System.Collections;

public class tiro : MonoBehaviour {

	public float fuerza = 100;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButton("Fire1")) {
			GameObject bola = (GameObject) Instantiate(Resources.Load("Bola"),this.transform.position + Vector3.down, this.transform.rotation);
			bola.name = "bola";
			bola.tag = "bola";
			Rigidbody rbBala = bola.GetComponent<Rigidbody> ();
			rbBala.AddForce (transform.forward * fuerza);
		}
	
	}
}
