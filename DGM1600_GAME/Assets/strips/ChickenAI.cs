using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenAI : MonoBehaviour {

	public float moveSpeed;

	public Transform target;
	public Transform chickenPen;
	
	public int points = 10;

	// Use this for initialization
	
	
	void OnTriggerStay(Collider other)
	{
		if(other.gameObject.name == "Player"){
			Debug.Log("Player has entered chickens trigger");
			transform.LookAt(target);
			transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);




		}
	}

	

	
	
	// Update is called once per frame
	void OnCollisionEnter(Collision other){
		if(other.gameObject.name =="Player"){

		//Send chicken in chicken pen
		transform.position = chickenPen.position;
		transform.rotation = chickenPen.rotation;

		}
		
	}
}
