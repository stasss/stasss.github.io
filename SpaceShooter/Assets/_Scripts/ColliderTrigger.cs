﻿using UnityEngine;
using System.Collections;

public class ColliderTrigger : MonoBehaviour {

public GameObject explosion;
public GameObject playerExplosion;

  void OnTriggerEnter(Collider other) {
		if(other.tag != "Boundary"){
		Instantiate(explosion , transform.position , transform.rotation);
		if(other.tag == "Player"){
				Instantiate(playerExplosion , other.transform.position , other.transform.rotation);
		}
		Destroy(other.gameObject);
		Destroy(gameObject);
		}
   }
}
