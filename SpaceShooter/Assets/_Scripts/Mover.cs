using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {
    
	public float speed = 1f;

	void Start () {
	
		rigidbody.velocity = transform.forward * speed;

	}

}
