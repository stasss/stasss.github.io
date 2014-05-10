using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject hazard;
	public Vector3 spawnPos;


	void SpawnWave(){
		Vector3 pos = new Vector3(Random.Range(-6,6) , spawnPos.y , spawnPos.z);
		Quaternion rot = new Quaternion();
		Instantiate(hazard , pos , rot);
	}
	
	// Use this for initialization
	void Start () {
		SpawnWave();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
