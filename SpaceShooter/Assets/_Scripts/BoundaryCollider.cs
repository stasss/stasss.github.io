using UnityEngine;
using System.Collections;

public class BoundaryCollider : MonoBehaviour {

	void OnTriggerExit(Collider other) {
		 Destroy(other.gameObject);
	}

}
