﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boolet : MonoBehaviour {

	public int damage = 1;
	public int time = 5;

	// Use this for initialization
	void Start () {
		StartCoroutine(DestroyBullet());
		
	}

	IEnumerator DestroyBullet(){
		yield return new WaitForSeconds(time);
		Destroy(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
