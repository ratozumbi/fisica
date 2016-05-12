using UnityEngine;
using System.Collections;

public class mataBola : MonoBehaviour {


	void Awake(){
		Destroy (this.gameObject, 10);
		
	}
	// Use this for initialization
	void Start () {

		Physics.IgnoreCollision (this.GetComponent<Collider> (), GameObject.Find ("Camera").GetComponent<CharacterController> ());

		foreach (GameObject o in GameObject.FindGameObjectsWithTag ("bola"))
			Physics.IgnoreCollision (this.GetComponent<Collider> (), o.GetComponent<Collider>() );

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
