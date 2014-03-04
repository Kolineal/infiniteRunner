using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] obj;
	public int spawnLimit;
	public bool limited = false;
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
		if (limited) {
						if (spawnLimit > 0) {
								Instantiate (obj [Random.Range (0, obj.Length)], transform.position, Quaternion.identity);
								Invoke ("Spawn", Random.Range (minTime, maxTime));
								spawnLimit--;
						}
		} else {
			Instantiate (obj [Random.Range (0, obj.Length)], transform.position, Quaternion.identity);
			Invoke ("Spawn", Random.Range (minTime, maxTime));
		}
	}

}
