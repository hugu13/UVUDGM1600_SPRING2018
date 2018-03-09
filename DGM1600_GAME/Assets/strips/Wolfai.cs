using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolfai : MonoBehaviour {

	public float moveSpeed;
	public Transform target;
	public int damage;


	// Use this for initialization
	void OnTriggerStay(Collider other){

		if(other.gameObject.name == "Player"){
			transform.LookAt(target);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);

		}
		
	}
	
	// Update is called once per frame
	void OnCollisionEnter(Collision other) {

		print("Wolf is attacking!");
		 var hit = other.gameObject;
		 var health = hit.GetComponent<PlayerHealth>();


		 if(health != null){
		 	health.TakeDamage(damage);
		 }
		
	}
}
