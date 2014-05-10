using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary2D{
	public float xMin, xMax ,zMin, zMax;
}

public class PlayerController : MonoBehaviour {

	public float speed = 1f;
	public float tilt = 1f;
	public Boundary2D boundary;


	public float fireRate = 1f;
	private float nextFire;
	public GameObject shot;
	public Transform shotSpawn;



 void Update(){
		if(Input.GetButton("Fire1") && Time.time > nextFire){
			nextFire = Time.time + fireRate;
		Instantiate(shot, shotSpawn.position , shotSpawn.rotation );
		}
 }


 void FixedUpdate(){
		float mHorizontal = Input.GetAxis("Horizontal");
		float mVertical = Input.GetAxis("Vertical");

		rigidbody.velocity = new Vector3(mHorizontal * speed , 0f , mVertical * speed);

		rigidbody.position = new Vector3(
			Mathf.Clamp(rigidbody.position.x , boundary.xMin , boundary.xMax),
			0.0f,
			Mathf.Clamp(rigidbody.position.z , boundary.zMin , boundary.zMax)
		                
			);
		rigidbody.rotation = Quaternion.Euler(0f, 0f , rigidbody.velocity.x *  -tilt);
	
 }
}
