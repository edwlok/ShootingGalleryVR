using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour {

    public int score = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void updateScore()
    {
        score++;
        this.gameObject.GetComponent<TextMeshProUGUI>().text = "Score: " + score;
    }
}
