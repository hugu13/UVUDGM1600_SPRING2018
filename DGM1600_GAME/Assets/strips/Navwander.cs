using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navwander : MonoBehaviour {

	public float wanderRadius;
	public float wanderTimer;


	private UnityEngine.AI.NavMeshAgent Agent;
	private Transform target;
	private float timer;

	public Transform enemy;
	public Transform chickenpen;

	public int points;
	public bool isWandering = true;
	

	// Use this for initialization
	void OnEnable () {
		Agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		timer = wanderTimer;
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;

		if(timer>= wanderTimer) {
			Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
			Agent.SetDestination(newPos);
			timer = 0;
		}
		
	}
	public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask) {
		Vector3 randDirection = Random.insideUnitSphere * dist;
		randDirection += origin;
		UnityEngine.AI.NavMeshHit navHit;
		UnityEngine.AI.NavMesh.SamplePosition (randDirection, out navHit, dist, layermask);
		return navHit.position;
	}
	//Chicken Interactions
	//void OnTriggerStay(Collider other)
	//{
		//if(other.)
	//}
}

