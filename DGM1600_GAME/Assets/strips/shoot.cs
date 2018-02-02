using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class shoot : MonoBehaviour {

	public Rigidbody projectile;
	public Transform shootPoint;
	public int shootSpeed;
	

	// Use this for initialization
	void Update () {
	if(Input.GetButtonDown("Fire1")){
		Rigidbody clone;
			clone = (Rigidbody)Instantiate(projectile, shootPoint.position, projectile.rotation);
			clone.velocity = shootPoint.TransformDirection (Vector3. forward*shootSpeed*Time.deltaTime);
			

		}
			

	}

			

}
			






			

			
	
		
	
	
	// Update is called once per frame
	
		
	
