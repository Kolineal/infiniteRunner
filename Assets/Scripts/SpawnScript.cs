using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] obj;
	public float minTime = 1f;
	public float maxTime = 2f;
	// Use this for initialization
	void Start () {
		Spawn ();
	}
	// Update is called once per frame
	void Update () {
	
	}
	public void Spawn(){
		Instantiate (obj[Random.Range (0, obj.Length)], transform.position, Quaternion.identity);
		Invoke ("Spawn", Random.Range (minTime, maxTime));
	}

}
