using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {
	public int beer = 99; 

	public int bacon =9;
	// Use this for initialization
	void Start () {
		// for(int i=0;i > beer; i++){
			// print(i +"bottles of beer on the wall")
		// }

		// while(bacon>0){
			// print('mmmm bacon!!!'+bacon);

			// bacon --;
		// }
		// if bacon (<=0){
			// print("ohh out of bacon!!");
		// }

		// bool isFired = false;

		// do{
			// print("you're fired!!! - Donald Trump");
		// }
		// while(isFired == true);
		
		string[] churro = new string[3];

		churro[0] = "first churro, yum!";
		churro[1] = "second churro, ehh";
		churro[2] = "Third churrro, uueghh!";

		foreach(string item in churro){
			print(item);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
