using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wonder : MonoBehaviour {
	public float moveSpeed;
	public Transform target;

	//public int damage;

	//public GameObject pcHealth;

	// Use this for initialization
	// Update is called once per frame
	void Update () {
		
	}

	void Wondering(){
		print("wolf is Wondering");
		transform.Translate(vector3.forward*moveSpeed*Time.deltaTime);
		int randomNum = Random.Range(0,360);
		Vector3 fwd = transform.TransformDirection(Vector3.forward);
		Raycasthit hit;

		Debug.Drawray(transform.position,fwd*3,Color.red);

		if(physics.Raycast(transform.position,fwd,out hit,3)){

			if(hit.collider.tag == "wall"){
				transform.Rotate(0,randomNum,0);
			}
		}
	}

	void Following(){
		print("wolf is following");
		transform.LookAt(target);
		transform.Translate(vector3.forward*moveSpeed*Time.deltaTime);
	}

	void OnTriggerStay(collider other)
{
	if(other.gameObject.name == "Player")
			print("Player stinks!");
			//Following();

}
		

	

}	
		

 