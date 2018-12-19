using UnityEngine;
using System.Collections;

public class Rackets : MonoBehaviour {
	public KeyCode key_up;   
	public KeyCode key_down;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void FixedUpdate() {

		Vector3 pos = transform.position;

		if (Input.GetKey(key_up)) 
		{
			transform.position = new Vector3(pos.x,pos.y,pos.z + 0.1f);
		} 
		else if (Input.GetKey(key_down)) 
		{
			transform.position = new Vector3 (pos.x, pos.y, pos.z - 0.1f);
		}
	}
}
