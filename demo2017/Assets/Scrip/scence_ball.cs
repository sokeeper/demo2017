using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scence_ball : MonoBehaviour {
	public Text txtscore;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	int score = 0;
	public void Dopushbutton(){
		score++;
		txtscore.text = "Score :" + score.ToString ();
	}

	public void DochangeScene(){
		SceneManager.LoadScene (1);
		
	}
}
