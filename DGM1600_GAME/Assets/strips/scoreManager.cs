using  System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class scoreManager : MonoBehaviour {

	public static int score;
	public int winScore;
	public Text text;

	public Text winText;
	// Use this for initialization
	void Awake () {
		Time.timeScale = 1;

		
		
	}
	
	// Update is called once per frame
	void start(){
		winText.GetComponent<Text>().enable = false;
		text = GetComponent<Text>();
		score= 0;
	}

	void Update (){
		if(score< 0)
		score = 0;

		text.text= " "+ score;

		if(winScore == score){
			print("win score reached =" + score);
			winText.GetComponent<Text>().enable = true;
		}
		if(input.GetKeyDown(KeyCode.Escape)){
			scoreManager.LoadScene(0);
		}
	}
		
	public static void AddPoints(int pointsToADD){
		score += pointsToADD;
	}
	public void Reset(){
		score=0;
	}
}
