using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		GetComponent<Rigidbody>().velocity = Vector3.right;
	}
	
	// Update is called once per frame
	void Update () 
	{
		GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity.normalized;
	}

	void OnCollisionEnter(Collision collision) 

	{
		if (collision.collider.name == "BorderLeft") 
		{
		} 
		else if (collision.collider.name == "BorderRight") 
		{
		} 
		else if (collision.collider.name == "BorderTop") 
		{
			GetComponent<Rigidbody>().velocity = new Vector3 (GetComponent<Rigidbody>().velocity.x, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z * -1.0f);
		} 
		else if (collision.collider.name == "BorderBottom") 
		{
			GetComponent<Rigidbody>().velocity = new Vector3 (GetComponent<Rigidbody>().velocity.x, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z * -1.0f);
		} 
		else if (collision.collider.name == "RacketLeft") 
		{
			GetComponent<Rigidbody>().velocity = new Vector3 (GetComponent<Rigidbody>().velocity.z, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.x * -1.0f);
		}
		else if (collision.collider.name == "RacketRight")  
		{
			GetComponent<Rigidbody>().velocity = new Vector3 (GetComponent<Rigidbody>().velocity.z, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.x * -1.0f);
		}
	}
	}
		


